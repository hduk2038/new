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
    public partial class NewUserForm : Form
    {

        LoginForm loginForm = new LoginForm();




        private void SubmitBtn_Click(object sender, EventArgs e)

        {

            string username, password, reEnterPassword, userType, firstName, lastName, dob;

            try

            {

                username = usernameTxt.Text.Trim();
                password = passwordTxt.Text;
                reEnterPassword = ReEnterTxt.Text;
                userType = typeCmb.SelectedItem.ToString();
                firstName = FirstNameTxt.Text;
                lastName = LastNameTxt.Text;
                dob = Dob.Value.ToString("dd-MM-yyyy");


                if (password != reEnterPassword)
                {
                    MessageBox.Show("ERROR: Your password and confirmation password do not match.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //clear the text box of password and re-enter password
                    passwordTxt.Clear();
                    ReEnterTxt.Clear();

                }
                else if (username == "" || password == "" || reEnterPassword == "" || firstName == "" || lastName == "" || dob == "" || userType == "")
                {
                    MessageBox.Show("ERROR: Fill in the blanks", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateTime.Parse(dob) >= DateTime.Now.AddDays(-7))
                {
                    MessageBox.Show("ERROR: Incorrect date of birth", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Account account = new Account(username, password, userType, firstName, lastName, dob);
                    account.write();
                    DialogResult result = MessageBox.Show("Thanks! your account has been sucecessfully created", "SUCCESSFUL");
                    if (result == DialogResult.OK)
                    {
                        loginForm.Show();

                        this.Hide();



                    }

                }
            }

            catch (Exception)

            {
                MessageBox.Show("ERROR: Fill in the blanks", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public NewUserForm()

        {
            InitializeComponent();
            typeCmb.Items.Add("View");
            typeCmb.Items.Add("Edit");
            if (string.IsNullOrWhiteSpace(typeCmb.Text))
            {
                typeCmb.Text = "Select";
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {


            loginForm.Show();

            this.Hide();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
