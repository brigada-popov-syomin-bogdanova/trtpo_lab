using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            main.info_form_flag = true;
            
            //this.Owner = MainForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SearchListBox.Items.Clear();
            this.Hide();
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            main.info_form_flag = false;
        }

        private void SearchListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void SearchListBox_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm main = this.Owner as MainForm;

            int index = SearchListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string name = "";

                name = SearchListBox.SelectedItem.ToString();

                for (int i = 0; i < main.ElemList.Count(); ++i)
                {
                    if (name == main.ElemList[i].name)
                    {
                        main.NameTextBox.Text = main.ElemList[i].name;
                        main.DescRichTextBox.Text = main.ElemList[i].description;
                        main.DateTextBox.Text = main.ElemList[i].date;
                        main.AuthorsTextBox.Text = main.ElemList[i].authors;
                        main.CountryTextBox.Text = main.ElemList[i].country;
                        main.MBArtPictureBox.Image = Image.FromFile(main.ElemList[i].image);
                        main.MBArtPictureBox.ImageLocation = main.ElemList[i].image;
                        break;
                    }
                }
            }
        }
    }
}
