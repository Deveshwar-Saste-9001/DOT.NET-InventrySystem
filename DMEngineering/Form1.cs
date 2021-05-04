using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DMEngineering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DMEngineering\DMEngineering\DMEnggDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        private void Form1_Load(object sender, EventArgs e)
        {
            userName.Focus();

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from login where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                
              
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    Home log = new Home();
                    log.roletext = ds.Tables[0].Rows[0].Field<string>("role");
                    log.namelogin = ds.Tables[0].Rows[0].Field<string>("name");
                    log.Show();

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            userName.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2GradientButton1.PerformClick();
            }
        }
    }
}
