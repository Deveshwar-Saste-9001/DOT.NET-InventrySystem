namespace DMEngineering
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.customerPoduct = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customerDeleteBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.customerSubmitBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.customerPOno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customerGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customerAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label14);
            this.guna2GradientPanel1.Controls.Add(this.customerPoduct);
            this.guna2GradientPanel1.Controls.Add(this.customerDeleteBtn);
            this.guna2GradientPanel1.Controls.Add(this.customerSubmitBtn);
            this.guna2GradientPanel1.Controls.Add(this.customerPOno);
            this.guna2GradientPanel1.Controls.Add(this.customerGST);
            this.guna2GradientPanel1.Controls.Add(this.customerAddress);
            this.guna2GradientPanel1.Controls.Add(this.customerName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(803, 523);
            this.guna2GradientPanel1.TabIndex = 35;
            // 
            // customerPoduct
            // 
            this.customerPoduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerPoduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerPoduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPoduct.ForeColor = System.Drawing.Color.Black;
            this.customerPoduct.HintForeColor = System.Drawing.Color.Gray;
            this.customerPoduct.HintText = "Product";
            this.customerPoduct.isPassword = false;
            this.customerPoduct.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.customerPoduct.LineIdleColor = System.Drawing.Color.Gray;
            this.customerPoduct.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.customerPoduct.LineThickness = 3;
            this.customerPoduct.Location = new System.Drawing.Point(254, 262);
            this.customerPoduct.Margin = new System.Windows.Forms.Padding(4);
            this.customerPoduct.Name = "customerPoduct";
            this.customerPoduct.Size = new System.Drawing.Size(295, 38);
            this.customerPoduct.TabIndex = 42;
            this.customerPoduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.AnimationHoverSpeed = 0.07F;
            this.customerDeleteBtn.AnimationSpeed = 0.03F;
            this.customerDeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerDeleteBtn.BaseColor1 = System.Drawing.Color.DarkMagenta;
            this.customerDeleteBtn.BaseColor2 = System.Drawing.Color.HotPink;
            this.customerDeleteBtn.BorderColor = System.Drawing.Color.Black;
            this.customerDeleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.customerDeleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.customerDeleteBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.customerDeleteBtn.Image = null;
            this.customerDeleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.customerDeleteBtn.Location = new System.Drawing.Point(280, 409);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.customerDeleteBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.customerDeleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.customerDeleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.customerDeleteBtn.OnHoverImage = null;
            this.customerDeleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.customerDeleteBtn.Radius = 10;
            this.customerDeleteBtn.Size = new System.Drawing.Size(90, 35);
            this.customerDeleteBtn.TabIndex = 40;
            this.customerDeleteBtn.Text = "Back";
            this.customerDeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // customerSubmitBtn
            // 
            this.customerSubmitBtn.AnimationHoverSpeed = 0.07F;
            this.customerSubmitBtn.AnimationSpeed = 0.03F;
            this.customerSubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerSubmitBtn.BaseColor1 = System.Drawing.Color.Magenta;
            this.customerSubmitBtn.BaseColor2 = System.Drawing.Color.Crimson;
            this.customerSubmitBtn.BorderColor = System.Drawing.Color.Black;
            this.customerSubmitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.customerSubmitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.customerSubmitBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.customerSubmitBtn.Image = null;
            this.customerSubmitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.customerSubmitBtn.Location = new System.Drawing.Point(424, 409);
            this.customerSubmitBtn.Name = "customerSubmitBtn";
            this.customerSubmitBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.customerSubmitBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.customerSubmitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.customerSubmitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.customerSubmitBtn.OnHoverImage = null;
            this.customerSubmitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.customerSubmitBtn.Radius = 10;
            this.customerSubmitBtn.Size = new System.Drawing.Size(84, 35);
            this.customerSubmitBtn.TabIndex = 39;
            this.customerSubmitBtn.Text = "Next";
            this.customerSubmitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerSubmitBtn.Click += new System.EventHandler(this.customerSubmitBtn_Click);
            // 
            // customerPOno
            // 
            this.customerPOno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerPOno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerPOno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPOno.ForeColor = System.Drawing.Color.Black;
            this.customerPOno.HintForeColor = System.Drawing.Color.Gray;
            this.customerPOno.HintText = "PO No";
            this.customerPOno.isPassword = false;
            this.customerPOno.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.customerPOno.LineIdleColor = System.Drawing.Color.Gray;
            this.customerPOno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.customerPOno.LineThickness = 3;
            this.customerPOno.Location = new System.Drawing.Point(254, 334);
            this.customerPOno.Margin = new System.Windows.Forms.Padding(4);
            this.customerPOno.Name = "customerPOno";
            this.customerPOno.Size = new System.Drawing.Size(295, 38);
            this.customerPOno.TabIndex = 38;
            this.customerPOno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // customerGST
            // 
            this.customerGST.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerGST.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGST.ForeColor = System.Drawing.Color.Black;
            this.customerGST.HintForeColor = System.Drawing.Color.Gray;
            this.customerGST.HintText = "GST No";
            this.customerGST.isPassword = false;
            this.customerGST.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.customerGST.LineIdleColor = System.Drawing.Color.Gray;
            this.customerGST.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.customerGST.LineThickness = 3;
            this.customerGST.Location = new System.Drawing.Point(253, 200);
            this.customerGST.Margin = new System.Windows.Forms.Padding(4);
            this.customerGST.Name = "customerGST";
            this.customerGST.Size = new System.Drawing.Size(295, 38);
            this.customerGST.TabIndex = 37;
            this.customerGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // customerAddress
            // 
            this.customerAddress.AutoScroll = true;
            this.customerAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress.ForeColor = System.Drawing.Color.Black;
            this.customerAddress.HintForeColor = System.Drawing.Color.Gray;
            this.customerAddress.HintText = "Customer Address";
            this.customerAddress.isPassword = false;
            this.customerAddress.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.customerAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.customerAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.customerAddress.LineThickness = 3;
            this.customerAddress.Location = new System.Drawing.Point(253, 140);
            this.customerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(295, 38);
            this.customerAddress.TabIndex = 36;
            this.customerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // customerName
            // 
            this.customerName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.Color.Black;
            this.customerName.HintForeColor = System.Drawing.Color.Gray;
            this.customerName.HintText = "Customer Name";
            this.customerName.isPassword = false;
            this.customerName.LineFocusedColor = System.Drawing.Color.Blue;
            this.customerName.LineIdleColor = System.Drawing.Color.Gray;
            this.customerName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.customerName.LineThickness = 3;
            this.customerName.Location = new System.Drawing.Point(253, 83);
            this.customerName.Margin = new System.Windows.Forms.Padding(4);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(295, 38);
            this.customerName.TabIndex = 35;
            this.customerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(803, 39);
            this.label14.TabIndex = 43;
            this.label14.Text = "CUSTOMER";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 523);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerPoduct;
        private Guna.UI.WinForms.GunaGradientButton customerDeleteBtn;
        private Guna.UI.WinForms.GunaGradientButton customerSubmitBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerPOno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerGST;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerName;
        private System.Windows.Forms.Label label14;
    }
}