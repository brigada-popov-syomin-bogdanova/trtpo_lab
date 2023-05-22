namespace MovieManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GlobalTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.MBArtPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadNewButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DescRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NewItemButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CountryRadioButton = new System.Windows.Forms.RadioButton();
            this.AuthorsRadioButton = new System.Windows.Forms.RadioButton();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.GlobalTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBArtPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalTabControl
            // 
            this.GlobalTabControl.Controls.Add(this.tabPage1);
            this.GlobalTabControl.Controls.Add(this.tabPage2);
            this.GlobalTabControl.Location = new System.Drawing.Point(25, 108);
            this.GlobalTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.GlobalTabControl.Name = "GlobalTabControl";
            this.GlobalTabControl.SelectedIndex = 0;
            this.GlobalTabControl.Size = new System.Drawing.Size(466, 645);
            this.GlobalTabControl.TabIndex = 2;
            this.GlobalTabControl.SelectedIndexChanged += new System.EventHandler(this.GlobalTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MoviesListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(458, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 26;
            this.MoviesListBox.Location = new System.Drawing.Point(0, 2);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(5);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(453, 602);
            this.MoviesListBox.Sorted = true;
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoviesListBox_MouseClick);
            this.MoviesListBox.DoubleClick += new System.EventHandler(this.MoviesListBox_DoubleClick);
            this.MoviesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MoviesListBox_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BooksListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(458, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 26;
            this.BooksListBox.Location = new System.Drawing.Point(0, 5);
            this.BooksListBox.Margin = new System.Windows.Forms.Padding(5);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(453, 602);
            this.BooksListBox.Sorted = true;
            this.BooksListBox.TabIndex = 1;
            this.BooksListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BooksListBox_MouseClick);
            this.BooksListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BooksListBox_MouseDoubleClick);
            // 
            // MBArtPictureBox
            // 
            this.MBArtPictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MBArtPictureBox.Location = new System.Drawing.Point(29, 78);
            this.MBArtPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.MBArtPictureBox.Name = "MBArtPictureBox";
            this.MBArtPictureBox.Size = new System.Drawing.Size(189, 248);
            this.MBArtPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MBArtPictureBox.TabIndex = 3;
            this.MBArtPictureBox.TabStop = false;
            this.MBArtPictureBox.Click += new System.EventHandler(this.MBArtPictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LoadNewButton);
            this.groupBox1.Controls.Add(this.SaveSettingsButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CountryTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AuthorsTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateTextBox);
            this.groupBox1.Controls.Add(this.DescRichTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.MBArtPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(501, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(891, 654);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Artcover";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // LoadNewButton
            // 
            this.LoadNewButton.Location = new System.Drawing.Point(246, 265);
            this.LoadNewButton.Name = "LoadNewButton";
            this.LoadNewButton.Size = new System.Drawing.Size(123, 45);
            this.LoadNewButton.TabIndex = 14;
            this.LoadNewButton.Text = "Load new";
            this.LoadNewButton.UseVisualStyleBackColor = true;
            this.LoadNewButton.Click += new System.EventHandler(this.LoadNewButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(738, 23);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(145, 87);
            this.SaveSettingsButton.TabIndex = 12;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(348, 157);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(395, 34);
            this.CountryTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Country";
            // 
            // AuthorsTextBox
            // 
            this.AuthorsTextBox.Location = new System.Drawing.Point(348, 117);
            this.AuthorsTextBox.Name = "AuthorsTextBox";
            this.AuthorsTextBox.Size = new System.Drawing.Size(395, 34);
            this.AuthorsTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Аuthors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(348, 76);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(224, 34);
            this.DateTextBox.TabIndex = 6;
            // 
            // DescRichTextBox
            // 
            this.DescRichTextBox.Location = new System.Drawing.Point(29, 426);
            this.DescRichTextBox.Name = "DescRichTextBox";
            this.DescRichTextBox.Size = new System.Drawing.Size(842, 219);
            this.DescRichTextBox.TabIndex = 5;
            this.DescRichTextBox.Text = "";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(29, 360);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(842, 34);
            this.NameTextBox.TabIndex = 4;
            // 
            // NewItemButton
            // 
            this.NewItemButton.Location = new System.Drawing.Point(12, 42);
            this.NewItemButton.Name = "NewItemButton";
            this.NewItemButton.Size = new System.Drawing.Size(137, 41);
            this.NewItemButton.TabIndex = 4;
            this.NewItemButton.Text = "New item";
            this.NewItemButton.UseVisualStyleBackColor = true;
            this.NewItemButton.Click += new System.EventHandler(this.NewItemButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(155, 42);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(137, 41);
            this.DeleteItemButton.TabIndex = 5;
            this.DeleteItemButton.Text = "Delete item";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(427, 46);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(314, 34);
            this.SearchTextBox.TabIndex = 17;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(298, 42);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(123, 41);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1399, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CountryRadioButton);
            this.groupBox2.Controls.Add(this.AuthorsRadioButton);
            this.groupBox2.Controls.Add(this.DateRadioButton);
            this.groupBox2.Controls.Add(this.NameRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(747, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 80);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search parameters";
            // 
            // CountryRadioButton
            // 
            this.CountryRadioButton.AutoSize = true;
            this.CountryRadioButton.Location = new System.Drawing.Point(306, 33);
            this.CountryRadioButton.Name = "CountryRadioButton";
            this.CountryRadioButton.Size = new System.Drawing.Size(109, 30);
            this.CountryRadioButton.TabIndex = 3;
            this.CountryRadioButton.Text = "Country";
            this.CountryRadioButton.UseVisualStyleBackColor = true;
            // 
            // AuthorsRadioButton
            // 
            this.AuthorsRadioButton.AutoSize = true;
            this.AuthorsRadioButton.Location = new System.Drawing.Point(192, 31);
            this.AuthorsRadioButton.Name = "AuthorsRadioButton";
            this.AuthorsRadioButton.Size = new System.Drawing.Size(108, 30);
            this.AuthorsRadioButton.TabIndex = 2;
            this.AuthorsRadioButton.Text = "Authors";
            this.AuthorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Location = new System.Drawing.Point(111, 31);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(75, 30);
            this.DateRadioButton.TabIndex = 1;
            this.DateRadioButton.Text = "Date";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.Checked = true;
            this.NameRadioButton.Location = new System.Drawing.Point(18, 31);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(87, 30);
            this.NameRadioButton.TabIndex = 0;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "Name";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1399, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.NewItemButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GlobalTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MovieManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GlobalTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MBArtPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl GlobalTabControl;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListBox MoviesListBox;
        public System.Windows.Forms.ListBox BooksListBox;
        public System.Windows.Forms.PictureBox MBArtPictureBox;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DateTextBox;
        public System.Windows.Forms.RichTextBox DescRichTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox AuthorsTextBox;
        public System.Windows.Forms.Button NewItemButton;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox CountryTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button DeleteItemButton;
        public System.Windows.Forms.Button SaveSettingsButton;
        public System.Windows.Forms.Button LoadNewButton;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton CountryRadioButton;
        public System.Windows.Forms.RadioButton AuthorsRadioButton;
        public System.Windows.Forms.RadioButton DateRadioButton;
        public System.Windows.Forms.RadioButton NameRadioButton;
    }
}

