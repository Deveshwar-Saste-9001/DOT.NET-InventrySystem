using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace DMEngineering
{
    public partial class PrintInvoice : Form
    {
        public int id;
        public PrintInvoice()
        {
            InitializeComponent();
        }
        
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DMEngineering\DMEngineering\DMEnggDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void invoiceSubmitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            generatedby.Focus();
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader rdr;
          
            con = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT * FROM InvoiceTable where  InvoiceID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                To.Text = rdr.GetString(1)+" \n "+ rdr.GetString(3);
                invoiceNo.Text = "DM-INV2021000" + id;
                Date.Text = rdr.GetString(2);
                Product.Text = rdr.GetString(4);
                Rate.Text = rdr.GetString(5);
                Qty.Text = rdr.GetString(6);
                amount.Text = rdr.GetString(7);
                gst.Text = rdr.GetString(8);
                total.Text = rdr.GetString(9);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();


           

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(3508, 2480, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, 3508, 2480, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      //  private void invoiceEditBtn_Click_1(object sender, EventArgs e)
        //{
            
          //  PrintScreen();
            //printPreviewDialog1.ShowDialog();

        //}

        private void generatedby_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void generatedby_Enter(object sender, EventArgs e)
        {

        }

        private void generatedby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PrintScreen();
                printPreviewDialog1.ShowDialog();
            }
        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
