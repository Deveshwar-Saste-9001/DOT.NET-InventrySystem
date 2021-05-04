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
    public partial class Home : Form
    {
       public string roletext;
        public Boolean loadInword = false;
        public string namelogin;
        private Boolean logout = false;
        private int IDText=-1,rejectionIDText=-1,invoiceIDText=-1, dispatchIDText=-1, inwordIDText=-1;
        public Home()
        {
            InitializeComponent();
            this.customerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.MultiSelect = false;
            this.rejectionGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.rejectionGridView.MultiSelect = false;
            this.invoiceGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.invoiceGridView.MultiSelect = false;
            this.dispatchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dispatchGridView.MultiSelect = false;
            this.InwordGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.InwordGridView.MultiSelect = false;

        }
       
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DMEngineering\DMEngineering\DMEnggDatabase.mdf;Integrated Security=True;Connect Timeout=30";
       

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (logout)
            {
                Form1 login = new Form1();
                login.Show();
            }
            else
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
                    {

                        case DialogResult.Yes:
                            e.Cancel = false;
                            Application.Exit();
                            break;
                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                        default:
                            break;
                    }
                }
            }
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMEnggDatabaseDataSet5.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.dMEnggDatabaseDataSet5.login);
            // TODO: This line of code loads data into the 'dMEnggDatabaseDataSet4.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dMEnggDatabaseDataSet4.login);
            // TODO: This line of code loads data into the 'dMEnggDatabaseDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.dMEnggDatabaseDataSet3.Customer);
            // TODO: This line of code loads data into the 'dMEnggDatabaseDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.dMEnggDatabaseDataSet2.Customer);
            // TODO: This line of code loads data into the 'dMEnggDatabaseDataSet1.Customer' table. You can move, or remove it, as needed.
            // this.customerTableAdapter.Fill(this.dMEnggDatabaseDataSet1.Customer);
                role.Text = namelogin;
                roleandname.Text = (namelogin + " as " + roletext);
                bunifuCustomLabel2.Text = DateTime.Now.ToString();
                bunifuCustomLabel2.Text = DateTime.Now.ToString();
                if (roletext == "Admin")
                {
                    forAdmin1.Show();
                    forAdmin2.Show();

                }
                else
                {
                    forAdmin1.Hide();
                    forAdmin2.Hide();

                }
            if (loadInword)
            {
                panel3.BackColor = Color.DarkOrange;
                panel1.BackColor = Color.Transparent;
                panel11.BackColor = Color.Transparent;
                panel9.BackColor = Color.Transparent;
                panel5.BackColor = Color.Transparent;
                panel7.BackColor = Color.Transparent;
                ShowAllRecord(4);
               
                guna2GradientPanel2.Show();
                guna2GradientPanel1.Hide();
                guna2GradientPanel3.Hide();
                guna2GradientPanel4.Hide();
                guna2GradientPanel5.Hide();
                guna2GradientPanel6.Hide();
            }
            else
            {
                ShowAllRecord(1);
           
                guna2GradientPanel1.Show();
                guna2GradientPanel2.Hide();
                guna2GradientPanel3.Hide();
                guna2GradientPanel4.Hide();
                guna2GradientPanel5.Hide();
                guna2GradientPanel6.Hide();
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      //Panel hide and Show code*****

        private void label8_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkOrange;
            panel1.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            ShowAllRecord(4);
            if (roletext == "Admin")
            {
                forAdmin1.BackColor = Color.Transparent;
                forAdmin2.BackColor = Color.Transparent;
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();
            }

            guna2GradientPanel2.Show();
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel5.Hide();
            guna2GradientPanel6.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkOrange;
            panel9.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            if (roletext == "Admin")
            {
                forAdmin1.BackColor = Color.Transparent;
                forAdmin2.BackColor = Color.Transparent;
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();

            }
            
            guna2GradientPanel1.Show();
            guna2GradientPanel2.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel5.Hide();
            guna2GradientPanel6.Hide();

            ShowAllRecord(1);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.DarkOrange;
            panel1.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            if (roletext == "Admin")
            {
                forAdmin1.BackColor = Color.Transparent;
                forAdmin2.BackColor = Color.Transparent;
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();
            }
            ShowAllRecord(3);
            guna2GradientPanel3.Show();
            guna2GradientPanel1.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel5.Hide();
            guna2GradientPanel6.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel7.BackColor = Color.DarkOrange;
            panel1.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            if (roletext == "Admin")
            {
                forAdmin1.BackColor = Color.Transparent;
                forAdmin2.BackColor = Color.Transparent;
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();
            }
            ShowAllRecord(6);
            guna2GradientPanel4.Show();
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel5.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel6.Hide();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.DarkOrange;
            panel1.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            if (roletext == "Admin")
            {
                forAdmin1.BackColor = Color.Transparent;
                forAdmin2.BackColor = Color.Transparent;
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();
            }
            guna2GradientPanel5.Show();
            ShowAllRecord(5);
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel6.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.DarkOrange;
            panel1.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            if (roletext == "Admin")
            {
                forAdmin1.BackColor = Color.Transparent;
                forAdmin2.BackColor = Color.Transparent;
                guna2GradientPanel8.Hide();
                guna2GradientPanel7.Hide();
            }
            ShowAllRecord(2);
            guna2GradientPanel6.Show();
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel5.Hide();
            guna2GradientPanel2.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

      
        private void label21_Click(object sender, EventArgs e)
        {
            guna2GradientPanel7.Show();
            panel11.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            forAdmin1.BackColor = Color.DarkOrange;
            forAdmin2.BackColor = Color.Transparent;
            ShowAllRecord(7);
            guna2GradientPanel5.Hide();
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel8.Hide();

            guna2GradientPanel6.Hide();

        }

        private void label27_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            forAdmin1.BackColor = Color.Transparent;
            forAdmin2.BackColor = Color.DarkOrange;
            guna2GradientPanel8.Show();
            guna2GradientPanel7.Hide();
            guna2GradientPanel5.Hide();
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel4.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel6.Hide();
        }
        //Panel hide and Show code*****

 
        public void ShowAllRecord(int A)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter addapter;
            DataTable dt;
            switch (A)
            {
                case 1:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM Customer", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    customerGridView.DataSource = dt;
                    break;
                case 2:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM InvoiceTable", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    invoiceGridView.DataSource = dt;
                    break;
                case 3:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM Dispatch", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    dispatchGridView.DataSource = dt;
                    break;
                case 4:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM Inword", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    InwordGridView.DataSource = dt;
                    break;
                case 5:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM Inword", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    reconInwordGrid.DataSource = dt;
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM Dispatch", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    reconDispatchGridView.DataSource = dt;
                    break;
                case 6:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM Rejection", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    rejectionGridView.DataSource = dt;
                    break;
                case 7:
                    con = new SqlConnection(cs);
                    cmd = new SqlCommand("SELECT * FROM login", con);
                    addapter = new SqlDataAdapter();
                    dt = new DataTable();
                    addapter.SelectCommand = cmd;
                    addapter.Fill(dt);
                    userGridView.DataSource = dt;
                    break;
                default:
                    break;

            }
            
        }

        private void inwordSubmitBnt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Inword(Customer,Date,Material_Type,Weight,VehicalNo,Price,DC_No) VALUES (@customer, @date, @material, @weight,@vehical,@price,@dc)", con);
                cmd.Parameters.AddWithValue("@customer", inwordSelectCustomer.Text);
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
                ShowAllRecord(4);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

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
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customer(CustomerName,Address,GST,Products,PO) VALUES (@customerName, @address, @gst, @products,@po)", con);
                    cmd.Parameters.AddWithValue("@customerName", customerName.Text);
                    cmd.Parameters.AddWithValue("@address", customerAddress.Text);
                    cmd.Parameters.AddWithValue("@gst", customerGST.Text);
                    cmd.Parameters.AddWithValue("@products",customerPoduct.Text);
                    cmd.Parameters.AddWithValue("@po", customerPOno.Text);
                
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Succusfully");
                    customerName.Text = "";
                    customerPOno.Text = "";
                    customerAddress.Text = "";
                    customerPoduct.Text = "";
                    customerGST.Text = "";
                    ShowAllRecord(1);

                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

      
        private void invoiceSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dispatchSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO Dispatch(Customer,Date,Product,QTY,Weight,VehicalNo) VALUES (@customer, @date, @product, @qty,@weight,@vehical)", con);
                cmd.Parameters.AddWithValue("@customer", dispatchSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date", dispatchDateTime.Text);
                cmd.Parameters.AddWithValue("@product", dispatchProduct.Text);
                cmd.Parameters.AddWithValue("@qty",dispatchQTY.Text);
                cmd.Parameters.AddWithValue("@weight", dispatchWeight.Text);
                cmd.Parameters.AddWithValue("@vehical", dispatchVehical.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dispatch Recorded Succusfully");
                dispatchProduct.Text = "";
                dispatchQTY.Text = "";
                dispatchVehical.Text = "";
                dispatchWeight.Text = "";
                ShowAllRecord(3);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter addapter;
                DataTable dt;
                con = new SqlConnection(cs);
                cmd = new SqlCommand("SELECT * FROM Inword where Customer=@customer AND Date between @date1 and @date2", con);
                cmd.Parameters.AddWithValue("@customer", reconSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date1", reconbackdate.Text);
                cmd.Parameters.AddWithValue("@date2", recofrontdate.Text);
   
                addapter = new SqlDataAdapter();
                dt = new DataTable();
                addapter.SelectCommand = cmd;
                addapter.Fill(dt);
                reconInwordGrid.DataSource = dt;
                con = new SqlConnection(cs);
                cmd = new SqlCommand("SELECT * FROM Dispatch where Customer=@customer AND Date between @date1 and @date2", con);
                cmd.Parameters.AddWithValue("@customer", reconSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date1", reconbackdate.Text);
                cmd.Parameters.AddWithValue("@date2", recofrontdate.Text);

                addapter = new SqlDataAdapter();
                dt = new DataTable();
                addapter.SelectCommand = cmd;
                addapter.Fill(dt);
                reconDispatchGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recoClear_Click(object sender, EventArgs e)
        {
            ShowAllRecord(5);
        }

        private void rejectionSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("INSERT INTO Rejection(Customer,Date,DCNo,Product,Weight,VehicalNo) VALUES (@customer, @date,@dc, @material, @weight,@vehical)", con);
            cmd.Parameters.AddWithValue("@customer", rejectionSelectCustomer.Text);
            cmd.Parameters.AddWithValue("@date", rejectionDateTIme.Text);
            cmd.Parameters.AddWithValue("@dc", rejectionDCNo.Text);
            cmd.Parameters.AddWithValue("@material", rejectionProduct.Text);
            cmd.Parameters.AddWithValue("@weight", rejectionWeight.Text);
            cmd.Parameters.AddWithValue("@vehical", rejectionVehicalNo.Text);
        
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rejection Recorded Succusfully");
            rejectionDCNo.Text = "";
            rejectionProduct.Text = "";
            rejectionWeight.Text = "";
            inwordDCno.Text = "";
            ShowAllRecord(6);

            con.Close();
        }

        private void invoiceSubmitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO InvoiceTable(Customer,Date,PO,Products,Rate,Qty,Total,GST,Amount_with_GST) VALUES (@customerName, @date, @po, @products,@rate,@qty,@total,@gst,@amount)", con);
                cmd.Parameters.AddWithValue("@customerName", invoiceSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date", invoiceDateTime.Text);
                cmd.Parameters.AddWithValue("@po", invoicePO.Text);
                cmd.Parameters.AddWithValue("@products", invoceProduct.Text);
                cmd.Parameters.AddWithValue("@rate", invoiceProductRate.Text);
                cmd.Parameters.AddWithValue("@qty", invoiceProductQty.Text);
                cmd.Parameters.AddWithValue("@total", invoiceTotalAmount.Text);
                cmd.Parameters.AddWithValue("@gst", invoiceGST.Text);
                cmd.Parameters.AddWithValue("@amount", invoiceAmountwithgst.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("invoice Added Succusfully");
                invoiceProductRate.Text = "";
                invoiceProductQty.Text = "";
                invoceProduct.Text = "";
                invoiceProductRate.Text = "";
                invoicePO.Text = "";
                invoiceAmountwithgst.Text = "";
                invoiceTotalAmount.Text = "";
                invoiceGST.Text = "";
                ShowAllRecord(2);

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
       }

        private void invoiceProductQty_OnValueChanged(object sender, EventArgs e)
        {
            if (invoiceProductRate.Text!= "")
            {
                int percentage = 18;
                if (invoiceProductQty.Text != "")
                {
                    int total = Convert.ToInt32(invoiceProductRate.Text) * Convert.ToInt32(invoiceProductQty.Text);
                    invoiceTotalAmount.Text = total.ToString();
                    double gst = (double)total * (0.18);
                    invoiceGST.Text = gst.ToString();
                    invoiceAmountwithgst.Text = (total + gst).ToString();
                }
            }
        }


        private void customerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerGridView.Rows[e.RowIndex];
                //  MessageBox.Show(row.Cells[0].Value.ToString());
                IDText = Convert.ToInt32(row.Cells[0].Value.ToString());
                customerName.Text = row.Cells[1].Value.ToString();
                customerAddress.Text = row.Cells[2].Value.ToString();
                customerGST.Text = row.Cells[3].Value.ToString();
                customerPOno.Text = row.Cells[5].Value.ToString();
                customerPoduct.Text = row.Cells[4].Value.ToString();

            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
            logout = true;
            this.Close();
        }

        private void customerEditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET CustomerName = @customerName, Address = @address,GST=@gst,Products=@products,PO=@po Where ID = @id", con);
                cmd.Parameters.AddWithValue("@id", IDText);

                cmd.Parameters.AddWithValue("@customerName", customerName.Text);
                cmd.Parameters.AddWithValue("@address", customerAddress.Text);
                cmd.Parameters.AddWithValue("@gst", customerGST.Text);
                cmd.Parameters.AddWithValue("@products", customerPoduct.Text);
                cmd.Parameters.AddWithValue("@po", customerPOno.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Customer Record  Succusfully");
                customerName.Text = "";
                customerPOno.Text = "";
                customerAddress.Text = "";
                customerPoduct.Text = "";
                customerGST.Text = "";
                ShowAllRecord(1);

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("DELETE Customer Where ID = @id", con);
                cmd.Parameters.AddWithValue("@id", IDText);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Customer Record Deleted Succusfully");
                customerName.Text = "";
                customerPOno.Text = "";
                customerAddress.Text = "";
                customerPoduct.Text = "";
                customerGST.Text = "";
                ShowAllRecord(1);

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rejectionEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE Rejection SET Customer = @customerName, Date = @date,DC=@dc,Product=@product,Weight=@weight,VehicalNo=@vehicalNo Where ID = @id", con);
                cmd.Parameters.AddWithValue("@id", rejectionIDText);
                cmd.Parameters.AddWithValue("@customerName", rejectionSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date",  rejectionDateTIme.Text);
                cmd.Parameters.AddWithValue("@dc", rejectionDCNo.Text);
                cmd.Parameters.AddWithValue("@product", rejectionProduct.Text);
                cmd.Parameters.AddWithValue("@weight",rejectionWeight.Text);
                cmd.Parameters.AddWithValue("@vehicalNo", rejectionVehicalNo.Text);
                                                               
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Rejection Record  Succusfully");
                rejectionDCNo.Text = "";
                rejectionProduct.Text = "";
                rejectionWeight.Text = "";
                rejectionVehicalNo.Text = "";
                ShowAllRecord(1);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rejectionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("DELETE Rejection Where ID = @id", con);
                cmd.Parameters.AddWithValue("@id", rejectionIDText);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Rejection Record Deleted Succusfully");
                customerName.Text = "";
                customerPOno.Text = "";
                customerAddress.Text = "";
                customerPoduct.Text = "";
                customerGST.Text = "";
                ShowAllRecord(1);

                con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void submitAdduser_Click(object sender, EventArgs e)
        {
            if (passwordAdduser.Text != confirmPasswordAdduser.Text)
            {
                MessageBox.Show("Password doesn't match");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("INSERT INTO login(username,password,name,role) VALUES (@usernamet, @passwordt, @namet, @rolet)", con);
                    cmd.Parameters.AddWithValue("@usernamet", usernameAddUser.Text);
                    cmd.Parameters.AddWithValue("@passwordt", passwordAdduser.Text);
                    cmd.Parameters.AddWithValue("@namet", NameAdduser.Text);
                    cmd.Parameters.AddWithValue("@rolet", SelectRoleAdduser.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Created Succusfully");
                    usernameAddUser.Text = "";
                    passwordAdduser.Text = "";
                    confirmPasswordAdduser.Text = "";
                    NameAdduser.Text = "";
                    ShowAllRecord(7);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void doneBtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (newPasswordupdateUser.Text != confirmPasswordupdateUser.Text)
            {
                MessageBox.Show("Password doesn't match");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("UPDATE login SET password = @password Where username = @username", con);
                    cmd.Parameters.AddWithValue("@username", selectUserUpdateUser.Text);
                    cmd.Parameters.AddWithValue("@password", newPasswordupdateUser.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Reseted Succusfully");
                    newPasswordupdateUser.Text = "";
                    confirmPasswordupdateUser.Text = "";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void invoiceEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE InvoiceTable SET Customer = @customerName, Date = @date,PO=@po,Products=@product,Rate=@rate,Qty=@qty,Total=@total,GST=@gst,Amount_with_GST=@awithg Where InvoiceID = @id", con);
                cmd.Parameters.AddWithValue("@id", invoiceIDText);
                cmd.Parameters.AddWithValue("@customerName", invoiceSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date", invoiceDateTime.Text);
                cmd.Parameters.AddWithValue("@po", invoicePO.Text);
                cmd.Parameters.AddWithValue("@product", invoceProduct.Text);
                cmd.Parameters.AddWithValue("@rate", invoiceProductRate.Text);
                cmd.Parameters.AddWithValue("@qty", invoiceProductQty.Text);
                cmd.Parameters.AddWithValue("@total", invoiceTotalAmount.Text);
                cmd.Parameters.AddWithValue("@gst", invoiceGST.Text);
                cmd.Parameters.AddWithValue("@awithg", invoiceAmountwithgst.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Invoice Record  Succusfully");
                invoicePO.Text = "";
                invoiceProductRate.Text = "";
                invoiceProductQty.Text = "";
                invoceProduct.Text = "";
                invoiceTotalAmount.Text = "";
                invoiceGST.Text = "";
                invoiceAmountwithgst.Text = "";
                
                ShowAllRecord(2);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void invoiceDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("DELETE InvoiceTable Where InvoiceID = @id", con);
                cmd.Parameters.AddWithValue("@id", invoiceIDText);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Invoice Record Deleted Succusfully");
                invoicePO.Text = "";
                invoiceProductRate.Text = "";
                invoiceProductQty.Text = "";
                invoceProduct.Text = "";
                invoiceTotalAmount.Text = "";
                invoiceGST.Text = "";
                invoiceAmountwithgst.Text = "";
                ShowAllRecord(2);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter addapter;
                DataTable dt;
                con = new SqlConnection(cs);
                cmd = new SqlCommand("SELECT * FROM Inword where Date between @date1 and @date2", con);
                cmd.Parameters.AddWithValue("@date1", reconbackdate.Text);
                cmd.Parameters.AddWithValue("@date2", recofrontdate.Text);

                addapter = new SqlDataAdapter();
                dt = new DataTable();
                addapter.SelectCommand = cmd;
                addapter.Fill(dt);
                reconInwordGrid.DataSource = dt;
                con = new SqlConnection(cs);
                cmd = new SqlCommand("SELECT * FROM Dispatch where Date between @date1 and @date2", con);
                cmd.Parameters.AddWithValue("@date1", reconbackdate.Text);
                cmd.Parameters.AddWithValue("@date2", recofrontdate.Text);

                addapter = new SqlDataAdapter();
                dt = new DataTable();
                addapter.SelectCommand = cmd;
                addapter.Fill(dt);
                reconDispatchGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter addapter;
                DataTable dt;
                con = new SqlConnection(cs);
                cmd = new SqlCommand("SELECT * FROM Inword where Customer=@customer", con);
                cmd.Parameters.AddWithValue("@customer", reconSelectCustomer.Text);


                addapter = new SqlDataAdapter();
                dt = new DataTable();
                addapter.SelectCommand = cmd;
                addapter.Fill(dt);
                reconInwordGrid.DataSource = dt;
                con = new SqlConnection(cs);
                cmd = new SqlCommand("SELECT * FROM Dispatch where Customer=@customer", con);
                cmd.Parameters.AddWithValue("@customer", reconSelectCustomer.Text);
               

                addapter = new SqlDataAdapter();
                dt = new DataTable();
                addapter.SelectCommand = cmd;
                addapter.Fill(dt);
                reconDispatchGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dispatchEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE Dispatch SET Customer = @customerName, Date = @date,Product=@product,QTY=@qty,Weight=@weight,VehicalNo=@vehicalNo Where DispatchID = @id", con);
                cmd.Parameters.AddWithValue("@id", dispatchIDText);
                cmd.Parameters.AddWithValue("@customerName", dispatchSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date", dispatchDateTime.Text);
                cmd.Parameters.AddWithValue("@product", dispatchProduct.Text);
                cmd.Parameters.AddWithValue("@qty", dispatchQTY.Text);
                cmd.Parameters.AddWithValue("@weight", dispatchWeight.Text);
                cmd.Parameters.AddWithValue("@vehocalNo", dispatchVehical.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Dispatch Record  Succusfully");
                dispatchProduct.Text = "";
                dispatchQTY.Text = "";
                dispatchVehical.Text = "";
                dispatchWeight.Text = "";
                ShowAllRecord(3);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dispatchDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("DELETE Dispatch Where DispatchID = @id", con);
                cmd.Parameters.AddWithValue("@id", dispatchIDText);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Dispatch Record Deleted Succusfully");
                dispatchProduct.Text = "";
                dispatchQTY.Text = "";
                dispatchVehical.Text = "";
                dispatchWeight.Text = "";
                ShowAllRecord(3);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inwordEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE Inword SET Customer = @customerName, Date = @date,Material_Type=@product,Weight=@weight,VehicalNo=@vehicalNo,Price=@price,DC_No=@dc Where InwordID = @id", con);
                cmd.Parameters.AddWithValue("@id", inwordIDText);
                cmd.Parameters.AddWithValue("@customer", inwordSelectCustomer.Text);
                cmd.Parameters.AddWithValue("@date", InwordSelectDate.Text);
                cmd.Parameters.AddWithValue("@product", inwordMetalType.Text);
                cmd.Parameters.AddWithValue("@weight", inwordWeight.Text);
                cmd.Parameters.AddWithValue("@vehicalNo", inwordVehicalNo.Text);
                cmd.Parameters.AddWithValue("@price", inwordPrice.Text);
                cmd.Parameters.AddWithValue("@dc", inwordDCno.Text);

                
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Inword Record  Succusfully");
                inwordMetalType.Text = "";
                inwordWeight.Text = "";
                inwordVehicalNo.Text = "";
                inwordPrice.Text = "";
                inwordDCno.Text = "";
                ShowAllRecord(4);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void inwordDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("DELETE Inword Where InwordID = @id", con);
                cmd.Parameters.AddWithValue("@id", inwordIDText);

                con.Open();
                cmd.ExecuteNonQuery();
                inwordMetalType.Text = "";
                inwordWeight.Text = "";
                inwordVehicalNo.Text = "";
                inwordPrice.Text = "";
                inwordDCno.Text = "";
                ShowAllRecord(4);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inwordAddNewCusto_Click(object sender, EventArgs e)
        {
            AddUser customer = new AddUser();
            customer.Show();
            this.Hide();
        }

        private void guna2GradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            if (invoiceIDText >= 0)
            {
                PrintInvoice print = new PrintInvoice();
                print.id = invoiceIDText;
                print.Show();
            }else
            {
                MessageBox.Show("Please Select Invoice to print");
            }
          
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InwordGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.InwordGridView.Rows[e.RowIndex];
                inwordIDText = Convert.ToInt32(row.Cells[0].Value.ToString());
            //    MessageBox.Show(row.Cells[0].Value.ToString());
                inwordSelectCustomer.Text = row.Cells[1].Value.ToString();
                InwordSelectDate.Text = row.Cells[2].Value.ToString();
                inwordMetalType.Text = row.Cells[3].Value.ToString();
                inwordWeight.Text = row.Cells[4].Value.ToString();
                inwordVehicalNo.Text = row.Cells[5].Value.ToString();
                inwordPrice.Text = row.Cells[6].Value.ToString();
                inwordDCno.Text = row.Cells[7].Value.ToString();


            }
        }

        private void dispatchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dispatchGridView.Rows[e.RowIndex];
                dispatchIDText = Convert.ToInt32(row.Cells[0].Value.ToString());
             //   MessageBox.Show(row.Cells[0].Value.ToString());
                dispatchSelectCustomer.Text = row.Cells[1].Value.ToString();
                dispatchDateTime.Text = row.Cells[2].Value.ToString();
                dispatchProduct.Text = row.Cells[3].Value.ToString();
                dispatchQTY.Text = row.Cells[4].Value.ToString();
                dispatchWeight.Text = row.Cells[5].Value.ToString();
                dispatchVehical.Text = row.Cells[6].Value.ToString();
              
            }

        }

        private void invoiceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.invoiceGridView.Rows[e.RowIndex];
                invoiceIDText = Convert.ToInt32(row.Cells[0].Value.ToString());
             //   MessageBox.Show(row.Cells[0].Value.ToString());
                invoiceSelectCustomer.Text = row.Cells[1].Value.ToString();
                invoiceDateTime.Text = row.Cells[2].Value.ToString();
                invoicePO.Text = row.Cells[3].Value.ToString();
                invoceProduct.Text = row.Cells[4].Value.ToString();
                invoiceProductRate.Text = row.Cells[5].Value.ToString();
                invoiceProductQty.Text = row.Cells[6].Value.ToString();
                invoiceTotalAmount.Text = row.Cells[7].Value.ToString();
                invoiceGST.Text = row.Cells[8].Value.ToString();
                invoiceAmountwithgst.Text = row.Cells[9].Value.ToString();

            }
        }

        private void rejectionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.rejectionGridView.Rows[e.RowIndex];
                rejectionIDText = Convert.ToInt32(row.Cells[0].Value.ToString());
              //  MessageBox.Show(row.Cells[0].Value.ToString());
                rejectionSelectCustomer.Text= row.Cells[1].Value.ToString();
                rejectionDateTIme.Text = row.Cells[2].Value.ToString();
                rejectionDCNo.Text = row.Cells[3].Value.ToString();
                rejectionProduct.Text = row.Cells[4].Value.ToString();
                rejectionWeight.Text = row.Cells[5].Value.ToString();
                rejectionVehicalNo.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
