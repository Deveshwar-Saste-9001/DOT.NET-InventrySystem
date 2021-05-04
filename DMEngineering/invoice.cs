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
  
    public partial class invoice : Form
    {
        public  static string customerdata;
        private Boolean next = false;
        public invoice()
        {
            InitializeComponent();
            CustomerName.Text = customerdata;


        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DMEngineering\DMEngineering\DMEnggDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!next)
            {
                Home home = new Home();
                home.Show();
            }

        }
        private void invoiceSubmitBtn_Click(object sender, EventArgs e)
        {
            
           
        }

        private void inwordSubmitBnt_Click(object sender, EventArgs e)
        {
            try
            {
                next = true;
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Inword(Customer,Date,Material_Type,Weight,VehicalNo,Price,DC_No) VALUES (@customer, @date, @material, @weight,@vehical,@price,@dc)", con);
                cmd.Parameters.AddWithValue("@customer", CustomerName.Text);
                cmd.Parameters.AddWithValue("@date", InwordSelectDate.Text);
                cmd.Parameters.AddWithValue("@material", inwordMetalType.Text);
                cmd.Parameters.AddWithValue("@weight", inwordWeight.Text);
                cmd.Parameters.AddWithValue("@vehical", inwordVehicalNo.Text);
                cmd.Parameters.AddWithValue("@price", inwordPrice.Text);
                cmd.Parameters.AddWithValue("@dc", inwordDCno.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inword Recorded Succusfully");
                inwordMetalType.Text = "";
                inwordWeight.Text = "";
                inwordVehicalNo.Text = "";
                inwordPrice.Text = "";
                inwordDCno.Text = "";
                Home home = new Home();
                home.loadInword = true;
                home.Show();
                this.Close();


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2GradientPanel6_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            CustomerName.Text = AddUser.customerValue;
        }
    }
}
