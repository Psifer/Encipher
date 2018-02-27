namespace PasswordSaver
{
    partial class CreateAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSetupCode = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtAccountTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.setupButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginPage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exitButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Title:";
            // 
            // txtSetupCode
            // 
            this.txtSetupCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSetupCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetupCode.ForeColor = System.Drawing.Color.White;
            this.txtSetupCode.Location = new System.Drawing.Point(21, 288);
            this.txtSetupCode.Multiline = true;
            this.txtSetupCode.Name = "txtSetupCode";
            this.txtSetupCode.ReadOnly = true;
            this.txtSetupCode.Size = new System.Drawing.Size(251, 105);
            this.txtSetupCode.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.txtAccountTitle.BorderColorIdle = System.Drawing.Color.White;
            this.txtAccountTitle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.txtAccountTitle.BorderThickness = 1;
            this.txtAccountTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountTitle.ForeColor = System.Drawing.Color.White;
            this.txtAccountTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAccountTitle.isPassword = false;
            this.txtAccountTitle.Location = new System.Drawing.Point(91, 205);
            this.txtAccountTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(180, 29);
            this.txtAccountTitle.TabIndex = 31;
            this.txtAccountTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAccountTitle_KeyDown);
            // 
            // setupButton
            // 
            this.setupButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setupButton.BorderRadius = 0;
            this.setupButton.ButtonText = "Generate Account/ Get QR Code";
            this.setupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setupButton.DisabledColor = System.Drawing.Color.Gray;
            this.setupButton.Iconcolor = System.Drawing.Color.Transparent;
            this.setupButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("setupButton.Iconimage")));
            this.setupButton.Iconimage_right = null;
            this.setupButton.Iconimage_right_Selected = null;
            this.setupButton.Iconimage_Selected = null;
            this.setupButton.IconMarginLeft = 0;
            this.setupButton.IconMarginRight = 0;
            this.setupButton.IconRightVisible = true;
            this.setupButton.IconRightZoom = 0D;
            this.setupButton.IconVisible = false;
            this.setupButton.IconZoom = 90D;
            this.setupButton.IsTab = false;
            this.setupButton.Location = new System.Drawing.Point(21, 236);
            this.setupButton.Name = "setupButton";
            this.setupButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setupButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.setupButton.OnHoverTextColor = System.Drawing.Color.White;
            this.setupButton.selected = false;
            this.setupButton.Size = new System.Drawing.Size(251, 48);
            this.setupButton.TabIndex = 30;
            this.setupButton.Text = "Generate Account/ Get QR Code";
            this.setupButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setupButton.Textcolor = System.Drawing.Color.White;
            this.setupButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // loginPage
            // 
            this.loginPage.ActiveBorderThickness = 1;
            this.loginPage.ActiveCornerRadius = 20;
            this.loginPage.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginPage.ActiveForecolor = System.Drawing.Color.White;
            this.loginPage.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.loginPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPage.BackgroundImage")));
            this.loginPage.ButtonText = "Login";
            this.loginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginPage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPage.ForeColor = System.Drawing.Color.White;
            this.loginPage.IdleBorderThickness = 1;
            this.loginPage.IdleCornerRadius = 20;
            this.loginPage.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(46)))));
            this.loginPage.IdleForecolor = System.Drawing.Color.White;
            this.loginPage.IdleLineColor = System.Drawing.Color.White;
            this.loginPage.Location = new System.Drawing.Point(21, 395);
            this.loginPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(120, 39);
            this.loginPage.TabIndex = 29;
            this.loginPage.TabStop = false;
            this.loginPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPage.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // exitButton
            // 
            this.exitButton.ActiveBorderThickness = 1;
            this.exitButton.ActiveCornerRadius = 20;
            this.exitButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.exitButton.ActiveForecolor = System.Drawing.Color.White;
            this.exitButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.ButtonText = "Exit";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.IdleBorderThickness = 1;
            this.exitButton.IdleCornerRadius = 20;
            this.exitButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(46)))));
            this.exitButton.IdleForecolor = System.Drawing.Color.White;
            this.exitButton.IdleLineColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(174, 395);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 39);
            this.exitButton.TabIndex = 28;
            this.exitButton.TabStop = false;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.Transparent;
            this.pbQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQR.Location = new System.Drawing.Point(39, 9);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(213, 191);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQR.TabIndex = 4;
            this.pbQR.TabStop = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(296, 436);
            this.Controls.Add(this.txtAccountTitle);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.txtSetupCode);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2FA Account Creation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.TextBox txtSetupCode;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 exitButton;
        private Bunifu.Framework.UI.BunifuThinButton2 loginPage;
        private Bunifu.Framework.UI.BunifuFlatButton setupButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAccountTitle;
    }
}
