using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{

    public partial class TextEditorForm : Form
    {

        public TextEditorForm()
        {
            InitializeComponent();
        }

        public ToolStripLabel UsernameLbl
        {
            get { return usernameLbl; }
        }

        public RichTextBox RichTextBox
        {
            get { return richTextBox1; }
        }
        private void textEditorForm_Load(object sender, EventArgs e)
        {

        }





        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();


            openFile.Title = "Open a RTF File";
            openFile.Filter = "RTF Files|*rtf";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathLbl.Text = openFile.FileName;
                richTextBox1.LoadFile(pathLbl.Text);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathLbl.Text))
            {
                richTextBox1.SaveFile(pathLbl.Text, RichTextBoxStreamType.RichText);
            }
            //if
            else if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                return;
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "RTF Files|*.rtf";

            DialogResult result = saveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
            }
        }



        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }


        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            About aboutBox = new About();


            aboutBox.Show();
        }



        private void saveToolBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathLbl.Text))
            {
                richTextBox1.SaveFile(pathLbl.Text, RichTextBoxStreamType.RichText);
            }
            else if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                return;
            }
            else
            {
                saveAsToolBtn_Click(sender, e);
            }

        }


        private void newToolBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes to Untitled", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    saveAsToolBtn_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
            }
            else
            {
                richTextBox1.Clear();
            }
        }

        private void openToolBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Open a RTF File";
            //filter the file type to open
            openFile.Filter = "RTF Files|*rtf";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathLbl.Text = openFile.FileName;
                richTextBox1.LoadFile(pathLbl.Text);
            }
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes to Untitled", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    saveAsToolBtn_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
            }

        }



        private void saveAsToolBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "RTF Files|*.rtf";

            DialogResult result = saveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
            }
        }



        private void boldToolBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }



        private void italicToolBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }

        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();

            loginForm.Show();


            this.Hide();
        }
        private void underlineToolBtn_Click(object sender, EventArgs e)

        {
            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }


        private void textSizeCmb_SelectedIndexChanged(object sender, EventArgs e)

        {
            richTextBox1.SelectionFont = new Font(Font.FontFamily, Convert.ToInt32(textSizeCmb.SelectedItem), richTextBox1.SelectionFont.Style);
        }


        private void helpToolBtn_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.Show();

        }

        private void cutToolBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }


        private void pasteToolBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
