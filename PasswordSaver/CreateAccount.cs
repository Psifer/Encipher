using Google.Authenticator;
using LiteDB;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PasswordSaver
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            txtAccountTitle.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("dbFile.db"))
            {
                var db = new LiteDatabase("dbFile.db");
            }
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            string alphabetString = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var db = new LiteDatabase("dbFile.db");
            var col = db.GetCollection<Main.AccountInfo>("AccountInfo");

            if (txtAccountTitle.Text == "")
            {
                MessageBox.Show("Please Enter Account Name.");
            }
            else
            {
                TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
                string secretKey = Main.GenerateString(20, alphabetString);
                string pass = Main.GenerateString(16, alphabetString);
                string secretKeyEncrypt = Main.EncryptString(secretKey, pass);
                string accountEncrypt = Main.EncryptString(txtAccountTitle.Text, pass);
                var setupCode = tfA.GenerateSetupCode(txtAccountTitle.Text, secretKey, pbQR.Width, pbQR.Height);
                col.Delete(1);
                col.Insert(new Main.AccountInfo { Id = 1, Vector = pass, Account = accountEncrypt, Key = secretKeyEncrypt, IsActive = true });
                var check = db.CollectionExists("WebsiteInfo");
                if(check == true)
                {
                    db.DropCollection("WebsiteInfo");
                    var collect = db.GetCollection<Main.WebsiteInfo>("WebsiteInfo");

                }
                WebClient wc = new WebClient();
                MemoryStream ms = new MemoryStream(wc.DownloadData(setupCode.QrCodeSetupImageUrl));
                pbQR.Image = Image.FromStream(ms);
                txtSetupCode.Text = "Account: " + setupCode.Account + System.Environment.NewLine +
                    "Encoded Key: " + setupCode.ManualEntryKey + System.Environment.NewLine +
                    "Backup Key for Google Authenticator";
            }
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            var db = new LiteDatabase("dbFile.db");
            var check = db.CollectionExists("AccountInfo");

            if (check == false)
            {
                MessageBox.Show("You must create an account to go back to the login page." + "\n" + "Press Exit to close program.");
            }
            else
            {
                Hide();
                Login x = new Login();
                x.ShowDialog();
                Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAccountTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetupButton_Click(null, null);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}

