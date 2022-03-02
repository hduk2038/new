using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment2
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewUserbtn_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();

            newUserForm.Show();

            this.Hide();
        }


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Loginbtn_Click(object sender, EventArgs e)
        {
            TextEditorForm textEditorForm = new TextEditorForm();

            LoginForm loginForm = new LoginForm();
            string username, password;

            try

            {
                username = UsernameTxt.Text;
                password = passwordTxt.Text;
                Account account = new Account();
                bool valid = account.check(username, password);
                if (valid)
                {
                    MessageBox.Show("Successful Login", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textEditorForm.Show();
                    textEditorForm.UsernameLbl.Text = "Username: " + username;
                    if (account.getUserType() == "View")
                    {
                        textEditorForm.RichTextBox.ReadOnly = true;
                        textEditorForm.RichTextBox.Cursor = Cursors.No;
                    }
                }
                else if (username == "" || password == "")
                {
                    MessageBox.Show("Username and Password cannot be null or empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginForm.Show();


                }

                else
                {
                    MessageBox.Show("Uncorrect username and password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginForm.Show();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Please Try Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
