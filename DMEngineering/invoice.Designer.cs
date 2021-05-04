namespace DMEngineering
{
    partial class invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.guna2GradientPanel6 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.inwordSubmitBnt = new Guna.UI.WinForms.GunaGradientButton();
            this.inwordDCno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inwordPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.InwordSelectDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.inwordVehicalNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inwordWeight = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inwordMetalType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2GradientPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel6
            // 
            this.guna2GradientPanel6.AutoScroll = true;
            this.guna2GradientPanel6.AutoSize = true;
            this.guna2GradientPanel6.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2GradientPanel6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientPanel6.Controls.Add(this.label14);
            this.guna2GradientPanel6.Controls.Add(this.inwordSubmitBnt);
            this.guna2GradientPanel6.Controls.Add(this.inwordDCno);
            this.guna2GradientPanel6.Controls.Add(this.inwordPrice);
            this.guna2GradientPanel6.Controls.Add(this.InwordSelectDate);
            this.guna2GradientPanel6.Controls.Add(this.inwordVehicalNo);
            this.guna2GradientPanel6.Controls.Add(this.CustomerName);
            this.guna2GradientPanel6.Controls.Add(this.inwordWeight);
            this.guna2GradientPanel6.Controls.Add(this.inwordMetalType);
            this.guna2GradientPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel6.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2GradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel6.Name = "guna2GradientPanel6";
            this.guna2GradientPanel6.ShadowDecoration.Parent = this.guna2GradientPanel6;
            this.guna2GradientPanel6.Size = new System.Drawing.Size(860, 547);
            this.guna2GradientPanel6.TabIndex = 19;
            this.guna2GradientPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel6_Paint);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(860, 39);
            this.label14.TabIndex = 25;
            this.label14.Text = "INWORD";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inwordSubmitBnt
            // 
            this.inwordSubmitBnt.AnimationHoverSpeed = 0.07F;
            this.inwordSubmitBnt.AnimationSpeed = 0.03F;
            this.inwordSubmitBnt.BackColor = System.Drawing.Color.Transparent;
            this.inwordSubmitBnt.BaseColor1 = System.Drawing.Color.Magenta;
            this.inwordSubmitBnt.BaseColor2 = System.Drawing.Color.Crimson;
            this.inwordSubmitBnt.BorderColor = System.Drawing.Color.Black;
            this.inwordSubmitBnt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.inwordSubmitBnt.FocusedColor = System.Drawing.Color.Empty;
            this.inwordSubmitBnt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwordSubmitBnt.ForeColor = System.Drawing.Color.White;
            this.inwordSubmitBnt.Image = null;
            this.inwordSubmitBnt.ImageSize = new System.Drawing.Size(20, 20);
            this.inwordSubmitBnt.Location = new System.Drawing.Point(553, 239);
            this.inwordSubmitBnt.Name = "inwordSubmitBnt";
            this.inwordSubmitBnt.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.inwordSubmitBnt.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.inwordSubmitBnt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.inwordSubmitBnt.OnHoverForeColor = System.Drawing.Color.White;
            this.inwordSubmitBnt.OnHoverImage = null;
            this.inwordSubmitBnt.OnPressedColor = System.Drawing.Color.Black;
            this.inwordSubmitBnt.Radius = 10;
            this.inwordSubmitBnt.Size = new System.Drawing.Size(133, 63);
            this.inwordSubmitBnt.TabIndex = 21;
            this.inwordSubmitBnt.Text = "Submit";
            this.inwordSubmitBnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inwordSubmitBnt.Click += new System.EventHandler(this.inwordSubmitBnt_Click);
            // 
            // inwordDCno
            // 
            this.inwordDCno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inwordDCno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inwordDCno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwordDCno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inwordDCno.HintForeColor = System.Drawing.Color.DimGray;
            this.inwordDCno.HintText = "DC.No";
            this.inwordDCno.isPassword = false;
            this.inwordDCno.LineFocusedColor = System.Drawing.Color.Blue;
            this.inwordDCno.LineIdleColor = System.Drawing.Color.Gray;
            this.inwordDCno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inwordDCno.LineThickness = 3;
            this.inwordDCno.Location = new System.Drawing.Point(111, 417);
            this.inwordDCno.Margin = new System.Windows.Forms.Padding(4);
            this.inwordDCno.Name = "inwordDCno";
            this.inwordDCno.Size = new System.Drawing.Size(295, 38);
            this.inwordDCno.TabIndex = 20;
            this.inwordDCno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inwordPrice
            // 
            this.inwordPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inwordPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inwordPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwordPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inwordPrice.HintForeColor = System.Drawing.Color.DimGray;
            this.inwordPrice.HintText = "Price";
            this.inwordPrice.isPassword = false;
            this.inwordPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.inwordPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.inwordPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inwordPrice.LineThickness = 3;
            this.inwordPrice.Location = new System.Drawing.Point(111, 357);
            this.inwordPrice.Margin = new System.Windows.Forms.Padding(4);
            this.inwordPrice.Name = "inwordPrice";
            this.inwordPrice.Size = new System.Drawing.Size(295, 38);
            this.inwordPrice.TabIndex = 19;
            this.inwordPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // InwordSelectDate
            // 
            this.InwordSelectDate.BorderRadius = 10;
            this.InwordSelectDate.CheckedState.Parent = this.InwordSelectDate;
            this.InwordSelectDate.FillColor = System.Drawing.Color.White;
            this.InwordSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InwordSelectDate.HoverState.Parent = this.InwordSelectDate;
            this.InwordSelectDate.Location = new System.Drawing.Point(111, 127);
            this.InwordSelectDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.InwordSelectDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.InwordSelectDate.Name = "InwordSelectDate";
            this.InwordSelectDate.ShadowDecoration.Parent = this.InwordSelectDate;
            this.InwordSelectDate.Size = new System.Drawing.Size(295, 36);
            this.InwordSelectDate.TabIndex = 18;
            this.InwordSelectDate.Value = new System.DateTime(2021, 1, 21, 13, 51, 57, 576);
            // 
            // inwordVehicalNo
            // 
            this.inwordVehicalNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inwordVehicalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inwordVehicalNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwordVehicalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inwordVehicalNo.HintForeColor = System.Drawing.Color.DimGray;
            this.inwordVehicalNo.HintText = "Vehical No.";
            this.inwordVehicalNo.isPassword = false;
            this.inwordVehicalNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.inwordVehicalNo.LineIdleColor = System.Drawing.Color.Gray;
            this.inwordVehicalNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inwordVehicalNo.LineThickness = 3;
            this.inwordVehicalNo.Location = new System.Drawing.Point(111, 299);
            this.inwordVehicalNo.Margin = new System.Windows.Forms.Padding(4);
            this.inwordVehicalNo.Name = "inwordVehicalNo";
            this.inwordVehicalNo.Size = new System.Drawing.Size(295, 38);
            this.inwordVehicalNo.TabIndex = 17;
            this.inwordVehicalNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerName.HintForeColor = System.Drawing.Color.DimGray;
            this.CustomerName.HintText = "Customer";
            this.CustomerName.isPassword = false;
            this.CustomerName.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerName.LineIdleColor = System.Drawing.Color.Gray;
            this.CustomerName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerName.LineThickness = 3;
            this.CustomerName.Location = new System.Drawing.Point(111, 70);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(295, 38);
            this.CustomerName.TabIndex = 16;
            this.CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inwordWeight
            // 
            this.inwordWeight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inwordWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inwordWeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwordWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inwordWeight.HintForeColor = System.Drawing.Color.DimGray;
            this.inwordWeight.HintText = "Weight";
            this.inwordWeight.isPassword = false;
            this.inwordWeight.LineFocusedColor = System.Drawing.Color.Blue;
            this.inwordWeight.LineIdleColor = System.Drawing.Color.Gray;
            this.inwordWeight.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inwordWeight.LineThickness = 3;
            this.inwordWeight.Location = new System.Drawing.Point(111, 239);
            this.inwordWeight.Margin = new System.Windows.Forms.Padding(4);
            this.inwordWeight.Name = "inwordWeight";
            this.inwordWeight.Size = new System.Drawing.Size(295, 38);
            this.inwordWeight.TabIndex = 16;
            this.inwordWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inwordMetalType
            // 
            this.inwordMetalType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inwordMetalType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inwordMetalType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwordMetalType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inwordMetalType.HintForeColor = System.Drawing.Color.DimGray;
            this.inwordMetalType.HintText = "Metal type";
            this.inwordMetalType.isPassword = false;
            this.inwordMetalType.LineFocusedColor = System.Drawing.Color.Blue;
            this.inwordMetalType.LineIdleColor = System.Drawing.Color.Gray;
            this.inwordMetalType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inwordMetalType.LineThickness = 3;
            this.inwordMetalType.Location = new System.Drawing.Point(111, 182);
            this.inwordMetalType.Margin = new System.Windows.Forms.Padding(4);
            this.inwordMetalType.Name = "inwordMetalType";
            this.inwordMetalType.Size = new System.Drawing.Size(295, 38);
            this.inwordMetalType.TabIndex = 15;
            this.inwordMetalType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 547);
            this.Controls.Add(this.guna2GradientPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "invoice";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            this.guna2GradientPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel6;
        private Guna.UI.WinForms.GunaGradientButton inwordSubmitBnt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inwordDCno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inwordPrice;
        private Guna.UI2.WinForms.Guna2DateTimePicker InwordSelectDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inwordVehicalNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inwordWeight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inwordMetalType;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerName;
    }
}