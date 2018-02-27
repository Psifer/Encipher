using LiteDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// **Programmed by Psifer**
/// Version 2.0.0: 02/26/2018 7:37 A.M.
/// Release Stage:
///     To be done:
///         - Make db file invisible to user if needed.
///         - Add option to create categories
///         - Add time stamps for each entry
///         - Shakedown for bugs.
///         - Clean up Code(name changes, redundancy, etc.)
///     Comments:
///         - Encryption now includes salt & hash of passphrase.
///         - Delete Row and Delete Table have been implemented.
/// </summary>
/// 

namespace PasswordSaver
{
    public partial class Main : Form
    {
        private static string vector = "pemgail9uzpgzl88";//temporary vector value
        public static bool success = false;
        static Random rand = new Random();
        int count = 0;

        public Main()
        {
            InitializeComponent();
            encryptButton.Enabled = false;
            textBoxWebsite.Select();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //CreateAccount x = new CreateAccount(); //Open CreateAccount's Form before Login for Debugging
            //x.ShowDialog();
            
            Login x = new Login();
            x.ShowDialog();
            StartTimer();
            var database = new LiteDatabase("dbFile.db");
            GetVector();

            if (success != true)
            {
                Close();
            }
            else if(success == true && database.CollectionExists("WebsiteInfo") == true)
            {
                var db = new LiteDatabase("dbFile.db");
                var col = db.GetCollection<WebsiteInfo>("WebsiteInfo");
                int j = 0;

                for (int i = col.Min(); i <= col.Max(); i++)
                {
                    var WebsiteInfo = col.FindById(1);
                    try
                    {
                        WebsiteInfo = col.FindById(i);
                        if (WebsiteInfo.IsActive == true)
                        {
                            dataGrid.Rows.Add();
                            dataGrid.Rows[j].Cells[0].Value = WebsiteInfo.FullWebsite;
                            dataGrid.Rows[j].Cells[1].Value = WebsiteInfo.Username;
                            dataGrid.Rows[j].Cells[2].Value = WebsiteInfo.Password;
                            dataGrid.Rows[j].Cells[3].Value = WebsiteInfo.TimeStamp;
                            dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
                            j++;
                            count++;
                        }
                    }catch { }
                }
            }
            else
            {
                var db = new LiteDatabase("dbFile.db");
            }
        }

        /// <summary>
        /// Event Arguments
        /// </summary>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (passGenTextbox.Text == "")
                MessageBox.Show("You must generate a password in order to copy one.");
            else
                Clipboard.SetText(passGenTextbox.Text);
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "Column1")
            {
                DataGridViewLinkCell cell = (DataGridViewLinkCell)dgv[e.ColumnIndex, e.RowIndex];
                System.Diagnostics.Process.Start("http://" + cell.Value);
            }
        }

        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow r in dataGrid.Rows)
            {
                if (r.Selected == true && e.KeyCode == Keys.Delete)
                {
                    DeleteRowButton_Click(null, null);
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            var db = new LiteDatabase("dbFile.db");
            var col = db.GetCollection<AccountInfo>("AccountInfo");
            var AccountInfo = col.FindById(1);
            for (int i = 0; i < count; i++)
            {
                try
                {
                    string user = "", pass = "", userDecrypt = "", passDecrypt = "";
                    user = dataGrid.Rows[i].Cells[1].Value.ToString();
                    pass = dataGrid.Rows[i].Cells[2].Value.ToString();
                    userDecrypt = DecryptString(user, AccountInfo.Vector);
                    passDecrypt = DecryptString(pass, AccountInfo.Vector);
                    dataGrid.Rows[i].Cells[1].Value = userDecrypt;
                    dataGrid.Rows[i].Cells[2].Value = passDecrypt;
                }catch { }
            }
            decryptButton.Enabled = false;
            encryptButton.Enabled = true;
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            var db = new LiteDatabase("dbFile.db");
            if (dataGrid.Rows.Count == 1 && dataGrid.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("There is nothing to delete");
            }
            else
            {
                dataGrid.Rows.Clear();
                dataGrid.Refresh();
                db.DropCollection("WebsiteInfo");
                var col = db.GetCollection<WebsiteInfo>("WebsiteInfo");
                count = 0;
            }

        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count == 1 && dataGrid.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("There is nothing to delete");
            }
            else
            {
                foreach (DataGridViewRow row in dataGrid.SelectedRows)
                {
                    var db = new LiteDatabase("dbFile.db");
                    var col = db.GetCollection<WebsiteInfo>("WebsiteInfo");
                    string value = dataGrid.Rows[row.Index].Cells[0].Value.ToString();
                    var deleteSelection = col.FindOne(x => x.FullWebsite.Contains(value));
                    col.Delete(deleteSelection.Id);
                    dataGrid.Rows.RemoveAt(row.Index);
                    count--;
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            var db = new LiteDatabase("dbFile.db");
            var col = db.GetCollection<AccountInfo>("AccountInfo");
            var AccountInfo = col.FindById(1);
            for (int i = 0; i < count; i++)
            {
                try
                {
                    string user = "", pass = "", userEncrypt = "", passEncrypt = "";
                    user = dataGrid.Rows[i].Cells[1].Value.ToString();
                    pass = dataGrid.Rows[i].Cells[2].Value.ToString();
                    userEncrypt = EncryptString(user, AccountInfo.Vector);
                    passEncrypt = EncryptString(pass, AccountInfo.Vector);
                    dataGrid.Rows[i].Cells[1].Value = userEncrypt;
                    dataGrid.Rows[i].Cells[2].Value = passEncrypt;
                }catch { }
            }
            encryptButton.Enabled = false;
            decryptButton.Enabled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            string alphabet = "";
            int length = Int32.Parse(comboBox2.Text);

            if (lowerCaseCheckbox.Checked == false && upperCaseCheckbox.Checked == false && numbersCheckbox.Checked == false && symbolsCheckbox.Checked == false)
            {
                MessageBox.Show("Error: Please select an option to create password.");
            }
            if (lowerCaseCheckbox.Checked == true)
            {
                alphabet += "abcdefghijklmnopqrstuvwyxz";
            }
            if (upperCaseCheckbox.Checked == true)
            {
                alphabet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (numbersCheckbox.Checked == true)
            {
                alphabet += "0123456789";
            }
            if (symbolsCheckbox.Checked == true)
            {
                alphabet += "!@#$%^&*()-_+=?";
            }
            passGenTextbox.Text = GenerateString(length, alphabet);
        }

        private void HideTextSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (hideTextSwitch.Value == true)
            {
                textBoxUsername.isPassword = true;
                textBoxPassword.isPassword = true;
            }
            else
            {
                textBoxUsername.isPassword = false;
                textBoxPassword.isPassword = false;
            }
            textBoxWebsite.Focus();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PassGenButton_Click(object sender, EventArgs e)
        {
            passSaverPanel.Visible = false;
            copyButton.Visible = true;
            passGenPanel.Visible = true;
            passButtonPanel.Visible = false;
            passGenButton.Location = new System.Drawing.Point(0, 114);
        }

        private void PassSaverButton_Click(object sender, EventArgs e)
        {
            passGenPanel.Visible = false;
            copyButton.Visible = false;
            passSaverPanel.Visible = true;
            textBoxWebsite.Focus();
            passButtonPanel.Location = new System.Drawing.Point(0, 115);
            passButtonPanel.Visible = true;
            passGenButton.Location = new System.Drawing.Point(0, 257);
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            var db = new LiteDatabase("dbFile.db");
            var col = db.GetCollection<AccountInfo>("AccountInfo");
            var AccountInfo = col.FindById(1);
            string website, username, password;

            if (textBoxWebsite.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" ||
                textBoxWebsite.Text == "Website..." || textBoxUsername.Text == "Username..." || textBoxPassword.Text == "Password...")
            {
                MessageBox.Show("Please fill out input boxes");
            }
            else
            {
                website = textBoxWebsite.Text;
                username = EncryptString(textBoxUsername.Text, AccountInfo.Vector);
                password = EncryptString(textBoxPassword.Text, AccountInfo.Vector);
                string fullWebsite = ("www." + website + comboBox1.Text);
                DateTime localDate = DateTime.Now;

                dataGrid.Rows.Add();
                dataGrid.Rows[count].Cells[0].Value = fullWebsite;
                dataGrid.Rows[count].Cells[1].Value = username;
                dataGrid.Rows[count].Cells[2].Value = password;
                dataGrid.Rows[count].Cells[3].Value = localDate.ToString();
                dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
                count++;

                using (var datab = new LiteDatabase("dbFile.db"))
                {
                    var collect = datab.GetCollection<WebsiteInfo>("WebsiteInfo");

                    var WebsiteInfo = new WebsiteInfo
                    {
                        Website = website,
                        FullWebsite = fullWebsite,
                        Username = username,
                        Password = password,
                        IsActive = true,
                        TimeStamp = localDate.ToString()
                };
                    collect.Insert(WebsiteInfo);
                }
                textBoxWebsite.Text = "";
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxWebsite.Focus();
            }
        }

        private void SearchBox_OnTextChange(object sender, EventArgs e)
        {
            var db = new LiteDatabase("dbFile.db");
            var col = db.GetCollection<WebsiteInfo>("WebsiteInfo");
            var collect = db.GetCollection<AccountInfo>("AccountInfo");
            var AccountInfo = collect.FindById(1);
            string temp = searchBox.text;

            try
            {
                var searchInfo = col.FindById(col.Max());
                if (temp == "")
                {
                    int j = 0;
                    dataGrid.Rows.Clear();
                    dataGrid.Refresh();
                    for (int i = col.Min(); i <= col.Max(); i++)
                    {
                        searchInfo = col.FindById(i);
                        try
                        {
                            if (searchInfo.IsActive == true)
                            {
                                dataGrid.Rows.Add();
                                dataGrid.Rows[j].Cells[0].Value = searchInfo.FullWebsite;
                                dataGrid.Rows[j].Cells[1].Value = searchInfo.Username;
                                dataGrid.Rows[j].Cells[2].Value = searchInfo.Password;
                                dataGrid.Rows[j].Cells[3].Value = searchInfo.TimeStamp;
                                if (decryptButton.Enabled == false)
                                {
                                    decryptButton.Enabled = true;
                                    encryptButton.Enabled = false;
                                }
                                j++;
                            }
                        }catch { }
                    }
                    dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
                }
                else
                {
                    if (dataGrid.Rows.Count == 1 && dataGrid.Rows[0].Cells[0].Value == null && temp == null)
                    {

                    }
                    else
                    {
                        dataGrid.Rows.Clear();
                        dataGrid.Refresh();
                        int j = 0;
                        for (int i = col.Min(); i <= col.Max(); i++)
                        {
                            searchInfo = col.FindById(i);
                            try
                            {
                                if (searchInfo.Website.StartsWith(temp))
                                {
                                    dataGrid.Rows.Add();
                                    dataGrid.Rows[j].Cells[0].Value = searchInfo.FullWebsite;
                                    if (decryptButton.Enabled == false)
                                    {
                                        dataGrid.Rows[j].Cells[1].Value = DecryptString(searchInfo.Username, AccountInfo.Vector);
                                        dataGrid.Rows[j].Cells[2].Value = DecryptString(searchInfo.Password, AccountInfo.Vector);
                                    }
                                    else
                                    {
                                        dataGrid.Rows[j].Cells[1].Value = searchInfo.Username;
                                        dataGrid.Rows[j].Cells[2].Value = searchInfo.Password;
                                    }
                                    dataGrid.Rows[j].Cells[3].Value = searchInfo.TimeStamp;
                                    j++;
                                }
                            }
                            catch { }
                        }
                    }

                }
            }catch { }

        }

        private void SearchBox_KeyDown(object sender, EventArgs e)
        {
            if (e.Equals(Keys.Back))
            {
                decryptButton.Enabled = true;
                encryptButton.Enabled = false;
            }
        }

        private void SortAtoZButton_Click(object sender, EventArgs e)
        {
            dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
        }

        private void SortZtoAButton_Click(object sender, EventArgs e)
        {
            dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Descending);
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveInfo_Click(null, null);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void TextBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (textBoxWebsite.Text == "" || textBoxUsername.Text == "Username...")
                {
                    MessageBox.Show("Please enter a username to proceed.");
                }
                else
                {
                    textBoxPassword.Focus();
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void TextBoxWebsite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (textBoxWebsite.Text == "" || textBoxWebsite.Text == "Website...")
                {
                    MessageBox.Show("Please enter a website first.");
                }
                else
                {
                    textBoxUsername.Focus();
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Methods/Classes
        /// </summary>
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

        /*public static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove) //Currently unused, needed if plan to hide db file
        {
            return attributes & ~attributesToRemove;
        }*/

        public static string GenerateString(int size, string alphabet)
        {

            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = alphabet[rand.Next(alphabet.Length)];
            }
            return new string(chars);
        }

        public class WebsiteInfo
        {
            public int Id { get; set; }
            public string Website { get; set; }
            public string FullWebsite { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public bool IsActive { get; set; }
            public string TimeStamp { get; set; }
        }

        public class AccountInfo
        {
            public int Id { get; set; }
            public string Vector { get; set; }
            public string Account { get; set; }
            public string Key { get; set; }
            public bool IsActive { get; set; }
        }

        private static void GetVector()
        {
            var db = new LiteDatabase("dbFile.db");
            var col = db.GetCollection<AccountInfo>("AccountInfo");
            var accountVector = col.FindById(1);
            vector = accountVector.Vector;
        }

        public static string EncryptString(string text, string password)
        {
            byte[] pass = Encoding.UTF8.GetBytes(password);
            byte[] passHash = SHA256Managed.Create().ComputeHash(pass);
            byte[] txt = Encoding.UTF8.GetBytes(text);
            byte[] salt = GetRandomBytes();
            byte[] encryptedMessage = new byte[salt.Length + txt.Length];

            for (int i = 0; i < salt.Length; i++)
            {
                encryptedMessage[i] = salt[i];
            }
            for (int i = 0; i < txt.Length; i++)
            {
                encryptedMessage[i + salt.Length] = txt[i];
            }
            encryptedMessage = Encrypt(encryptedMessage, passHash);
            string result = Convert.ToBase64String(encryptedMessage);
            return result;
        }

        public static string DecryptString(string text, string password)
        {
            byte[] pass = Encoding.UTF8.GetBytes(password);
            byte[] passHash = SHA256Managed.Create().ComputeHash(pass);
            byte[] txt = Convert.FromBase64String(text);
            byte[] decryptedMessage = Decrypt(txt, passHash);
            int saltLength = 8;
            byte[] message = new byte[decryptedMessage.Length - saltLength];

            for (int i = 0; i < message.Length; i++)
            {
                message[i] = decryptedMessage[i + saltLength];
            }
            string result = Encoding.UTF8.GetString(message);
            return result;
        }

        public static byte[] Encrypt(byte[] toBeEncrypted, byte[] password)
        {
            byte[] encrypted = null;
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(password, salt, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;
                    using (var cStream = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(toBeEncrypted, 0, toBeEncrypted.Length);
                        cStream.Close();
                    }
                    encrypted = ms.ToArray();
                }
            }
            return encrypted;
        }

        public static byte[] Decrypt(byte[] toBeDecrypted, byte[] password)
        {
            byte[] decrypted = null;
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(password, salt, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;

                    using (var cStream = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(toBeDecrypted, 0, toBeDecrypted.Length);
                        cStream.Close();
                    }
                    decrypted = ms.ToArray();
                }
            }
            return decrypted;
        }

        public static byte[] GetRandomBytes()
        {
            int saltLength = 8;
            byte[] random = new byte[saltLength];
            RNGCryptoServiceProvider.Create().GetBytes(random);
            return random;
        }

    }
}

/// <summary>
/// Update Log:
/// 
/// Version 1.2.0: 02/14/2018 10:19 A.M.
/// Beta Stage:
///     To be done:
///         - Added salt & hash of passphrase to encryption methods.
///         - Implement a delete button for dataGrid.
///         - Add minimize buttons to all forms.
///         - Make db file invisible to user if needed.
///         - Shakedown for bugs.
///         - Clean up Code(name changes, redundancy, etc.)
///     Comments:
///         - RichTextBox now replaced with dataGrid.
///         - Program currently runs without any known bugs while using an embedded database as storage of info.
///         - Search bar has been added passSaverPanel.
///         - Account overriding not yet working.
///         
/// Version 1.1.0: 02/13/2018 1:23 P.M.
/// Beta Stage:
///     To be done:
///         - Add search bar to search for websites.
///         - Implement an embedded database instead of text files.
///         - Work on replacing richTextBox1.
///         - Fix error where new account is created but old text file stays there and won't decrypt properly.
///     Comments:
///         - Program currently runs without any known bugs while using text files as storage of info.
///         - Idea: Credit Card Info saving for websites.
///         - Idea: Auto-Login upon click from hyperlink in program.
///         - Idea: Hyperlinks to take you right to the page of the website.
///         
/// Version 1.0.0: 02/13/2018 12:47 A.M. 
/// Beta Stage:
///     To be done:
///         - Add "Copy" button to Password Generator.
///         - Add a button to close window in top right corner for Main.
///         - Allow user to create new account in case of losing 2fa connection(all data will be sacrificed).
///         - Work out any bugs.
///     Comments:
///         - Complete redesign of the UI for the mainpage has been completed.
///         - Added time and date to Login & Main page.
///         - Product now works as a multiple use case due to randomization of vector variable.
///         - Text files now hidden from user and edited in the background.
///         - Cleaned up some redundant coding.
/// 
/// Version 0.9.0: 02/12/2018 2:30 P.M.
/// Alpha Stage:
///     To be done:
///         - Randomize initVector variable.
///         - Password generator.
///         - Make text files invisible.
///         - GUI Restructure(Main, Login, CreateAccount Forms).
///     Comments:
///         - Program is working as a one-person use case until vector variable is randomized.
///         - Get rid of Windows 95 UI Theme.
///         - Need to come up with a good name for product.
/// 
/// </summary>
