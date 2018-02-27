using System;
using System.Windows.Forms;
using Google.Authenticator;
using LiteDB;

namespace PasswordSaver
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtCode.Select();
        }
        private string account, secretKey, accountEncrypted;

        private void Login_Load(object sender, EventArgs e)
        {
            StartTimer();
            var db = new LiteDatabase("dbFile.db");
            var check = db.CollectionExists("AccountInfo");

            if (check == true)
            {
                var col = db.GetCollection<Main.AccountInfo>("AccountInfo");
                var AccountInfo = col.FindById(1);
                accountEncrypted = AccountInfo.Account;
                account = Main.DecryptString(accountEncrypted, AccountInfo.Vector);
                secretKey = Main.DecryptString(AccountInfo.Key, AccountInfo.Vector);
                label1.Text = account;                
            }
            else
            {
                Hide();
                CreateAccount x = new CreateAccount();
                x.ShowDialog();
                Close();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
            var result = tfA.ValidateTwoFactorPIN(secretKey, txtCode.Text);
            bool value = result ? true : false;
            if(value == true)
            {
                Main.success = true;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect PIN");
                txtCode.Text = "";
                txtCode.Focus();
            }
        }

        private void TxtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(null, null);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if(accountEncrypted != null)
            {
                DialogResult warningMessage = MessageBox.Show("An existing account has been detected, creating a new one will result in loss of saved passwords. Are you sure you want to continue?", "Warning:",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warningMessage == DialogResult.Yes)
                {
                    Hide();
                    CreateAccount x = new CreateAccount();
                    x.ShowDialog();
                    Close();
                }
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void StartTimer()
        {
            Timer t = null;
            t = new Timer
            {
                Interval = 1000
            };
            t.Tick += new EventHandler(T_Tick);
            t.Enabled = true;
        }
        void T_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
}
