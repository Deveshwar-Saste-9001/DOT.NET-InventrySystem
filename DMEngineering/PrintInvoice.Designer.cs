namespace DMEngineering
{
    partial class PrintInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvoice));
            this.Date = new System.Windows.Forms.TextBox();
            this.invoiceNo = new System.Windows.Forms.TextBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.gst = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.generatedby = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.Form = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.Black;
            this.Date.Location = new System.Drawing.Point(385, 42);
            this.Date.Multiline = true;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(372, 39);
            this.Date.TabIndex = 62;
            this.Date.Text = "DATE:-";
            // 
            // invoiceNo
            // 
            this.invoiceNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNo.ForeColor = System.Drawing.Color.Black;
            this.invoiceNo.Location = new System.Drawing.Point(26, 42);
            this.invoiceNo.Multiline = true;
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.ReadOnly = true;
            this.invoiceNo.Size = new System.Drawing.Size(360, 39);
            this.invoiceNo.TabIndex = 61;
            this.invoiceNo.Text = "INVOICE NO.:-";
            // 
            // Qty
            // 
            this.Qty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.ForeColor = System.Drawing.Color.Black;
            this.Qty.Location = new System.Drawing.Point(595, 241);
            this.Qty.Multiline = true;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Size = new System.Drawing.Size(162, 308);
            this.Qty.TabIndex = 60;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.Location = new System.Drawing.Point(596, 618);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(162, 36);
            this.total.TabIndex = 60;
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gst
            // 
            this.gst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gst.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gst.ForeColor = System.Drawing.Color.Black;
            this.gst.Location = new System.Drawing.Point(596, 583);
            this.gst.Multiline = true;
            this.gst.Name = "gst";
            this.gst.ReadOnly = true;
            this.gst.Size = new System.Drawing.Size(162, 36);
            this.gst.TabIndex = 60;
            this.gst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.Black;
            this.amount.Location = new System.Drawing.Point(596, 546);
            this.amount.Multiline = true;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Size = new System.Drawing.Size(162, 38);
            this.amount.TabIndex = 60;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(595, 202);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(162, 39);
            this.textBox7.TabIndex = 60;
            this.textBox7.Text = "QUANTITY";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.ForeColor = System.Drawing.Color.Black;
            this.textBox18.Location = new System.Drawing.Point(425, 618);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(172, 36);
            this.textBox18.TabIndex = 60;
            this.textBox18.Text = "TOTAL";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // generatedby
            // 
            this.generatedby.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generatedby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedby.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedby.ForeColor = System.Drawing.Color.Black;
            this.generatedby.Location = new System.Drawing.Point(386, 654);
            this.generatedby.Multiline = true;
            this.generatedby.Name = "generatedby";
            this.generatedby.ReadOnly = true;
            this.generatedby.Size = new System.Drawing.Size(372, 72);
            this.generatedby.TabIndex = 60;
            this.generatedby.Text = "GENERATED BY:-";
            this.generatedby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generatedby.TextChanged += new System.EventHandler(this.generatedby_TextChanged);
            this.generatedby.Enter += new System.EventHandler(this.generatedby_Enter);
            this.generatedby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generatedby_KeyDown);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.Black;
            this.textBox15.Location = new System.Drawing.Point(26, 654);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(360, 72);
            this.textBox15.TabIndex = 60;
            this.textBox15.Text = "RECEIVED BY:-";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.Black;
            this.textBox16.Location = new System.Drawing.Point(425, 583);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(172, 36);
            this.textBox16.TabIndex = 60;
            this.textBox16.Text = "GST";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Black;
            this.textBox14.Location = new System.Drawing.Point(26, 583);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(399, 71);
            this.textBox14.TabIndex = 60;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(425, 546);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(172, 38);
            this.textBox12.TabIndex = 60;
            this.textBox12.Text = "AMOUNT";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Rate
            // 
            this.Rate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.ForeColor = System.Drawing.Color.Black;
            this.Rate.Location = new System.Drawing.Point(425, 241);
            this.Rate.Multiline = true;
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Size = new System.Drawing.Size(173, 308);
            this.Rate.TabIndex = 60;
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Product.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.ForeColor = System.Drawing.Color.Black;
            this.Product.Location = new System.Drawing.Point(26, 241);
            this.Product.Multiline = true;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Size = new System.Drawing.Size(401, 308);
            this.Product.TabIndex = 59;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(26, 546);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(401, 38);
            this.textBox11.TabIndex = 59;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // To
            // 
            this.To.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.To.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.Black;
            this.To.Location = new System.Drawing.Point(385, 77);
            this.To.Multiline = true;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Size = new System.Drawing.Size(372, 125);
            this.To.TabIndex = 60;
            // 
            // Form
            // 
            this.Form.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Form.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form.ForeColor = System.Drawing.Color.Black;
            this.Form.Location = new System.Drawing.Point(26, 77);
            this.Form.Multiline = true;
            this.Form.Name = "Form";
            this.Form.ReadOnly = true;
            this.Form.Size = new System.Drawing.Size(360, 125);
            this.Form.TabIndex = 59;
            this.Form.Text = "DM Engineering";
            this.Form.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(777, 39);
            this.label18.TabIndex = 57;
            this.label18.Text = "INVOICE";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel1.Controls.Add(this.Date);
            this.guna2GradientPanel1.Controls.Add(this.invoiceNo);
            this.guna2GradientPanel1.Controls.Add(this.Qty);
            this.guna2GradientPanel1.Controls.Add(this.total);
            this.guna2GradientPanel1.Controls.Add(this.gst);
            this.guna2GradientPanel1.Controls.Add(this.amount);
            this.guna2GradientPanel1.Controls.Add(this.textBox7);
            this.guna2GradientPanel1.Controls.Add(this.textBox18);
            this.guna2GradientPanel1.Controls.Add(this.generatedby);
            this.guna2GradientPanel1.Controls.Add(this.textBox15);
            this.guna2GradientPanel1.Controls.Add(this.textBox16);
            this.guna2GradientPanel1.Controls.Add(this.textBox14);
            this.guna2GradientPanel1.Controls.Add(this.textBox12);
            this.guna2GradientPanel1.Controls.Add(this.Rate);
            this.guna2GradientPanel1.Controls.Add(this.textBox6);
            this.guna2GradientPanel1.Controls.Add(this.Product);
            this.guna2GradientPanel1.Controls.Add(this.textBox11);
            this.guna2GradientPanel1.Controls.Add(this.To);
            this.guna2GradientPanel1.Controls.Add(this.textBox5);
            this.guna2GradientPanel1.Controls.Add(this.Form);
            this.guna2GradientPanel1.Controls.Add(this.label18);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(777, 749);
            this.guna2GradientPanel1.TabIndex = 42;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint_1);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(424, 202);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(174, 39);
            this.textBox6.TabIndex = 60;
            this.textBox6.Text = "RATE";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(26, 202);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(401, 39);
            this.textBox5.TabIndex = 59;
            this.textBox5.Text = "PRODUCT";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 749);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.PrintInvoice_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox invoiceNo;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox gst;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox generatedby;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox Form;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}