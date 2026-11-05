using System;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            Resize += (s, e) => CenterPanel();
            Shown += (s, e) => txtuser.Focus();
            CenterPanel();
        }

        private void CenterPanel()
        {
            panellogin.Left = (ClientSize.Width - panellogin.Width) / 2;
            panellogin.Top = (ClientSize.Height - panellogin.Height) / 2;
        }

        public void ShowAgain()
        {
            txtpassword.Clear();
            Show();
            txtuser.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter your username and password.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (username.Length == 0)
                {
                    txtuser.Focus();
                }
                else
                {
                    txtpassword.Focus();
                }

                return;
            }

            string fullName = "";
            bool valid = false;

            try
            {
                valid = Db.ValidateUser(username, password, out fullName, out _);

                if (valid)
                {
                    Db.LogActivity(username, "Logged in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the database.\n\n" + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!valid)
            {
                MessageBox.Show("Invalid username or password.", "Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
                return;
            }

            txtpassword.Clear();
            OpenMainMenu(username, fullName);
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenMainMenu(string username, string fullName)
        {
            var menu = new MainMenu(this, username, fullName);
            menu.FormClosed += (s, e) =>
            {
                if (!menu.LoggedOut)
                {
                    Application.Exit();
                }
            };

            menu.Show();
            Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (txtuser.Focused && (keyData == Keys.Enter || keyData == Keys.Down))
            {
                txtpassword.Focus();
                return true;
            }

            if (txtpassword.Focused && keyData == Keys.Up)
            {
                txtuser.Focus();
                return true;
            }

            if (txtpassword.Focused && keyData == Keys.Down)
            {
                btnlogin.Focus();
                return true;
            }

            if (btnlogin.Focused)
            {
                if (keyData == Keys.Right) { btnexit.Focus(); return true; }
                if (keyData == Keys.Up) { txtpassword.Focus(); return true; }
            }

            if (btnexit.Focused)
            {
                if (keyData == Keys.Left) { btnlogin.Focus(); return true; }
                if (keyData == Keys.Up) { txtpassword.Focus(); return true; }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}