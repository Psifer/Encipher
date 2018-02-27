namespace PasswordSaver
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.createAccountButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.loginButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Account:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            this.txtCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.txtCode.BorderColorIdle = System.Drawing.Color.White;
            this.txtCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.txtCode.BorderThickness = 3;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCode.isPassword = false;
            this.txtCode.Location = new System.Drawing.Point(96, 194);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(131, 47);
            this.txtCode.TabIndex = 23;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCode_KeyDown);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "accountname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(24, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(55, 22);
            this.timeLabel.TabIndex = 29;
            this.timeLabel.Text = "Time:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::Encipher.Properties.Resources.Close_Window_96px;
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(292, -3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(39, 36);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 32;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(115, 251);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 41);
            this.exitButton.TabIndex = 27;
            this.exitButton.TabStop = false;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.SeaGreen;
            this.createAccountButton.color = System.Drawing.Color.SeaGreen;
            this.createAccountButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.createAccountButton.ForeColor = System.Drawing.Color.White;
            this.createAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("createAccountButton.Image")));
            this.createAccountButton.ImagePosition = 16;
            this.createAccountButton.ImageZoom = 50;
            this.createAccountButton.LabelPosition = 34;
            this.createAccountButton.LabelText = "Create Account";
            this.createAccountButton.Location = new System.Drawing.Point(168, 37);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(6);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(131, 130);
            this.createAccountButton.TabIndex = 24;
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SeaGreen;
            this.loginButton.color = System.Drawing.Color.SeaGreen;
            this.loginButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = global::Encipher.Properties.Resources.Password_96px;
            this.loginButton.ImagePosition = 20;
            this.loginButton.ImageZoom = 50;
            this.loginButton.LabelPosition = 41;
            this.loginButton.LabelText = "Login";
            this.loginButton.Location = new System.Drawing.Point(28, 37);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(128, 129);
            this.loginButton.TabIndex = 17;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::Encipher.Properties.Resources.Minimize_Window_96px;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(256, -3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(39, 36);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 33;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(329, 303);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTileButton loginButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCode;
        private Bunifu.Framework.UI.BunifuTileButton createAccountButton;
        private Bunifu.Framework.UI.BunifuThinButton2 exitButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel timeLabel;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
    }
}