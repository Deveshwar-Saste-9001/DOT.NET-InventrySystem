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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        public static string customerValue;
        private Boolean next=false;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DMEngineering\DMEngineering\DMEnggDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public string customerdata { get; private set; }

        private void customerSubmitBtn_Click(object sender, EventArgs e)
        {
            if (customerName.Text == "")
            {
                customerName.Focus();
            }
            else if (customerAddress.Text == "")
            {
                // MessageBox.Show("Please provide Name of Customer");
                customerAddress.Focus();
            }
            else
            {
                try
                {
                    next = true;
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customer(CustomerName,Address,GST,Products,PO) VALUES (@customerName, @address, @gst, @products,@po)", con);
                    cmd.Parameters.AddWithValue("@customerName", customerName.Text);
                    cmd.Parameters.AddWithValue("@address", customerAddress.Text);
                    cmd.Parameters.AddWithValue("@gst", customerGST.Text);
                    cmd.Parameters.AddWithValue("@products", customerPoduct.Text);
                    cmd.Parameters.AddWithValue("@po", customerPOno.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    customerValue = customerName.Text;
                //    MessageBox.Show("Customer Added Succusfully");
                    customerName.Text = "";
                    customerPOno.Text = "";
                    customerAddress.Text = "";
                    customerPoduct.Text = "";
                    customerGST.Text = "";
                    //ShowAllRecord(1);
                    invoice inv = new invoice();
                    customerdata = customerName.Text;
                   
                    inv.Show();
                    this.Close();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!next)
            {
                Home home = new Home();
                home.Show();
            }
                
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.loadInword = true;
            home.Show();
            this.Close();
        }
    }
}
