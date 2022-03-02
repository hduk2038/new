namespace Assignment2
{
    partial class TextEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolBtn = new System.Windows.Forms.ToolStripButton();
            this.openToolBtn = new System.Windows.Forms.ToolStripButton();
            this.saveToolBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolBtn = new System.Windows.Forms.ToolStripButton();
            this.italicToolBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineToolBtn = new System.Windows.Forms.ToolStripButton();
            this.textSizeCmb = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolBtn = new System.Windows.Forms.ToolStripButton();
            this.usernameLbl = new System.Windows.Forms.ToolStripLabel();
            this.pathLbl = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutToolBtn = new System.Windows.Forms.ToolStripButton();
            this.copyToolBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteToolBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolBtn,
            this.openToolBtn,
            this.saveToolBtn,
            this.saveAsToolBtn,
            this.toolStripSeparator3,
            this.boldToolBtn,
            this.italicToolBtn,
            this.underlineToolBtn,
            this.textSizeCmb,
            this.helpToolBtn,
            this.usernameLbl,
            this.pathLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolBtn
            // 
            this.newToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("newToolBtn.Image")));
            this.newToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolBtn.Name = "newToolBtn";
            this.newToolBtn.Size = new System.Drawing.Size(24, 24);
            this.newToolBtn.Text = "New";
            this.newToolBtn.Click += new System.EventHandler(this.newToolBtn_Click);
            // 
            // openToolBtn
            // 
            this.openToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("openToolBtn.Image")));
            this.openToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolBtn.Name = "openToolBtn";
            this.openToolBtn.Size = new System.Drawing.Size(24, 24);
            this.openToolBtn.Text = "Open";
            this.openToolBtn.Click += new System.EventHandler(this.openToolBtn_Click);
            // 
            // saveToolBtn
            // 
            this.saveToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToolBtn.Image")));
            this.saveToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolBtn.Name = "saveToolBtn";
            this.saveToolBtn.Size = new System.Drawing.Size(24, 24);
            this.saveToolBtn.Text = "Save";
            this.saveToolBtn.Click += new System.EventHandler(this.saveToolBtn_Click);
            // 
            // saveAsToolBtn
            // 
            this.saveAsToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolBtn.Image")));
            this.saveAsToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolBtn.Name = "saveAsToolBtn";
            this.saveAsToolBtn.Size = new System.Drawing.Size(24, 24);
            this.saveAsToolBtn.Text = "Save As";
            this.saveAsToolBtn.Click += new System.EventHandler(this.saveAsToolBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // boldToolBtn
            // 
            this.boldToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldToolBtn.Image")));
            this.boldToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolBtn.Name = "boldToolBtn";
            this.boldToolBtn.Size = new System.Drawing.Size(24, 24);
            this.boldToolBtn.Text = "Bold";
            this.boldToolBtn.Click += new System.EventHandler(this.boldToolBtn_Click);
            // 
            // italicToolBtn
            // 
            this.italicToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicToolBtn.Image")));
            this.italicToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolBtn.Name = "italicToolBtn";
            this.italicToolBtn.Size = new System.Drawing.Size(24, 24);
            this.italicToolBtn.Text = "Italic";
            this.italicToolBtn.Click += new System.EventHandler(this.italicToolBtn_Click);
            // 
            // underlineToolBtn
            // 
            this.underlineToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolBtn.Image")));
            this.underlineToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolBtn.Name = "underlineToolBtn";
            this.underlineToolBtn.Size = new System.Drawing.Size(24, 24);
            this.underlineToolBtn.Text = "Underline";
            this.underlineToolBtn.Click += new System.EventHandler(this.underlineToolBtn_Click);
            // 
            // textSizeCmb
            // 
            this.textSizeCmb.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.textSizeCmb.Name = "textSizeCmb";
            this.textSizeCmb.Size = new System.Drawing.Size(140, 27);
            this.textSizeCmb.Text = "11";
            this.textSizeCmb.SelectedIndexChanged += new System.EventHandler(this.textSizeCmb_SelectedIndexChanged);
            // 
            // helpToolBtn
            // 
            this.helpToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("helpToolBtn.Image")));
            this.helpToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolBtn.Name = "helpToolBtn";
            this.helpToolBtn.Size = new System.Drawing.Size(24, 24);
            this.helpToolBtn.Text = "Help";
            this.helpToolBtn.Click += new System.EventHandler(this.helpToolBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(126, 24);
            this.usernameLbl.Text = "UserName HelloWorld";
            this.usernameLbl.Click += new System.EventHandler(this.usernameLbl_Click);
            // 
            // pathLbl
            // 
            this.pathLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(0, 24);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 49);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(865, 356);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolBtn,
            this.copyToolBtn,
            this.pasteToolBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 51);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(50, 365);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip2_ItemClicked);
            // 
            // cutToolBtn
            // 
            this.cutToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cutToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("cutToolBtn.Image")));
            this.cutToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolBtn.Name = "cutToolBtn";
            this.cutToolBtn.Size = new System.Drawing.Size(48, 24);
            this.cutToolBtn.Text = "Cut";
            this.cutToolBtn.Click += new System.EventHandler(this.cutToolBtn_Click);
            // 
            // copyToolBtn
            // 
            this.copyToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyToolBtn.Image")));
            this.copyToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolBtn.Name = "copyToolBtn";
            this.copyToolBtn.Size = new System.Drawing.Size(48, 24);
            this.copyToolBtn.Text = "Copy";
            this.copyToolBtn.Click += new System.EventHandler(this.copyToolBtn_Click);
            // 
            // pasteToolBtn
            // 
            this.pasteToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolBtn.Image")));
            this.pasteToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolBtn.Name = "pasteToolBtn";
            this.pasteToolBtn.Size = new System.Drawing.Size(48, 24);
            this.pasteToolBtn.Text = "Paste";
            this.pasteToolBtn.Click += new System.EventHandler(this.pasteToolBtn_Click);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 416);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TextEditorForm";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.textEditorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
              private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
           private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripButton newToolBtn;
        private System.Windows.Forms.ToolStripButton openToolBtn;
        private System.Windows.Forms.ToolStripButton saveToolBtn;
        private System.Windows.Forms.ToolStripButton saveAsToolBtn;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripButton boldToolBtn;
        private System.Windows.Forms.ToolStripButton italicToolBtn;
        private System.Windows.Forms.ToolStripButton underlineToolBtn;

        private System.Windows.Forms.ToolStripComboBox textSizeCmb;
        private System.Windows.Forms.ToolStripButton helpToolBtn;

        private System.Windows.Forms.ToolStripLabel usernameLbl;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.ToolStrip toolStrip2;

        private System.Windows.Forms.ToolStripButton cutToolBtn;
        private System.Windows.Forms.ToolStripButton copyToolBtn;
        private System.Windows.Forms.ToolStripButton pasteToolBtn;

        private System.Windows.Forms.ToolStripLabel pathLbl;
    }
}