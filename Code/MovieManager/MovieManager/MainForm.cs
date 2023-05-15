using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.CodeDom;

namespace MovieManager
{

    public partial class MainForm : Form
    {
        //[XmlArray("Collection"), XmlArrayItem("Item")]


        List<MovieBookData> ElemList;

        string filePath = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ElemList = new List<MovieBookData>();
            if (File.Exists("data.json"))
            {
                string data = File.ReadAllText("data.json");
                ElemList = JsonSerializer.Deserialize<List<MovieBookData>>(data);
            }

            for (int i = 0; i < ElemList.Count; ++i)
            {
                if (ElemList[i].type_flag == 0)
                {
                    MoviesListBox.Items.Add(ElemList[i].name);
                }
                if (ElemList[i].type_flag == 1)
                {
                    BooksListBox.Items.Add(ElemList[i].name);
                }
            }
        }

        private void NewItemButton_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                if (GlobalTabControl.SelectedIndex == 0)
                {
                    for (int i = 0; i < MoviesListBox.Items.Count; ++i)
                        if (MoviesListBox.Items[i].ToString() == NameTextBox.Text)
                        {
                            MessageBox.Show("Element with this name already exists");
                            return;                        
                        }
                    MovieBookData temp = new MovieBookData(NameTextBox.Text, DescRichTextBox.Text, DateTextBox.Text,
                    AuthorsTextBox.Text, CountryTextBox.Text, filePath, Convert.ToInt32(GlobalTabControl.SelectedIndex));
                    ElemList.Add(temp);
                    MoviesListBox.Items.Add(NameTextBox.Text);
                }

                if (GlobalTabControl.SelectedIndex == 1)
                {
                    for (int i = 0; i < BooksListBox.Items.Count; ++i)
                        if (BooksListBox.Items[i].ToString() == NameTextBox.Text)
                        {
                            MessageBox.Show("Element with this name already exists");
                            return;
                        }
                    MovieBookData temp = new MovieBookData(NameTextBox.Text, DescRichTextBox.Text, DateTextBox.Text,
                    AuthorsTextBox.Text, CountryTextBox.Text, filePath, Convert.ToInt32(GlobalTabControl.SelectedIndex));
                    ElemList.Add(temp);
                    BooksListBox.Items.Add(NameTextBox.Text);
                }



                string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                StreamWriter file = File.CreateText("data.json");
                file.WriteLine(json_temp);
                file.Close();
                MessageBox.Show("New item added!");
            }
            else
            {
                MessageBox.Show("Fields is clear");
            }

            NameTextBox.Text = "";
            DescRichTextBox.Text = "";
            DateTextBox.Text = "";
            AuthorsTextBox.Text = "";
            CountryTextBox.Text = "";
            MBArtPictureBox.Image = Image.FromFile("clear_image.jpg");
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (GlobalTabControl.SelectedIndex == 0)
            {
                for (int i = 0; i < ElemList.Count; ++i)
                {
                    if (ElemList[i].name == MoviesListBox.SelectedItem.ToString())
                    {
                        ElemList.Remove(ElemList[i]);
                        break;
                    }
                }

                NameTextBox.Text = "";
                DescRichTextBox.Text = "";
                DateTextBox.Text = "";
                AuthorsTextBox.Text = "";
                CountryTextBox.Text = "";
                MBArtPictureBox.Image = Image.FromFile("clear_image.jpg");

                MoviesListBox.Items.Remove(MoviesListBox.SelectedItem);
                string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                StreamWriter file = File.CreateText("data.json");
                file.WriteLine(json_temp);
                file.Close();
                MessageBox.Show("Item deleted!");
                return;

            }
            if (GlobalTabControl.SelectedIndex == 1)
            {
                for (int i = 0; i < ElemList.Count; ++i)
                {
                    if (ElemList[i].name == BooksListBox.SelectedItem.ToString())
                    {
                        ElemList.Remove(ElemList[i]);
                        break;
                    }
                }

                NameTextBox.Text = "";
                DescRichTextBox.Text = "";
                DateTextBox.Text = "";
                AuthorsTextBox.Text = "";
                CountryTextBox.Text = "";
                MBArtPictureBox.Image = Image.FromFile("clear_image.jpg");

                BooksListBox.Items.Remove(BooksListBox.SelectedItem);
                string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                StreamWriter file = File.CreateText("data.json");
                file.WriteLine(json_temp);
                file.Close();
                MessageBox.Show("Item deleted!");
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            if (MoviesListBox.Items.Count == 0 && BooksListBox.Items.Count == 0)
                return;

            if (GlobalTabControl.SelectedIndex == 0)
            {
                for (int i = 0; i < ElemList.Count; ++i)
                    if (ElemList[i].name == MoviesListBox.SelectedItem.ToString())
                    {
                        ElemList[i].name = NameTextBox.Text;
                        ElemList[i].description = DescRichTextBox.Text;
                        ElemList[i].date = DateTextBox.Text;
                        ElemList[i].authors = AuthorsTextBox.Text;
                        ElemList[i].country = CountryTextBox.Text;
                        ElemList[i].image = MBArtPictureBox.ImageLocation;

                        string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                        StreamWriter file = File.CreateText("data.json");
                        file.WriteLine(json_temp);
                        file.Close();

                        MoviesListBox.Items.Clear();

                        for (int j = 0; j < ElemList.Count; ++j)
                        {
                            if (ElemList[j].type_flag == 0)
                            {
                                MoviesListBox.Items.Add(ElemList[j].name);
                            }
                            if (ElemList[j].type_flag == 1)
                            {
                                BooksListBox.Items.Add(ElemList[j].name);
                            }
                        }
                        return;
                    }
            }

            if (GlobalTabControl.SelectedIndex == 1)
            {
                for (int i = 0; i < ElemList.Count; ++i)
                {
                    if (ElemList[i].name == BooksListBox.SelectedItem.ToString())
                    {
                        ElemList[i].name = NameTextBox.Text;
                        ElemList[i].description = DescRichTextBox.Text;
                        ElemList[i].date = DateTextBox.Text;
                        ElemList[i].authors = AuthorsTextBox.Text;
                        ElemList[i].country = CountryTextBox.Text;
                        ElemList[i].image = MBArtPictureBox.ImageLocation;


                        string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                        StreamWriter file = File.CreateText("data.json");
                        file.WriteLine(json_temp);
                        file.Close();
                        MessageBox.Show("Completed!");

                        BooksListBox.Items.Clear();

                        for (int j = 0; j < ElemList.Count; ++j)
                        {
                            if (ElemList[j].type_flag == 0)
                            {
                                MoviesListBox.Items.Add(ElemList[j].name);
                            }
                            if (ElemList[j].type_flag == 1)
                            {
                                BooksListBox.Items.Add(ElemList[j].name);
                            }
                        }

                        break;
                    }
                }
            }
        }



        private void LoadNewButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            try
            {
                MBArtPictureBox.Image = Image.FromFile(filePath);
                MBArtPictureBox.ImageLocation = filePath;
            }
            catch
            {
                MessageBox.Show("To big file!");
            }
        }
        private void SortList()
        {

        }

        private void LoadImage()
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help");
        }

        private void MoviesListBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LoadPicture(string file_path)
        {

        }

        private void MoviesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.MoviesListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string name = "";

                name = MoviesListBox.SelectedItem.ToString();

                for (int i = 0; i < ElemList.Count(); ++i)
                {
                    if (name == ElemList[i].name)
                    {
                        NameTextBox.Text = ElemList[i].name;
                        DescRichTextBox.Text = ElemList[i].description;
                        DateTextBox.Text = ElemList[i].date;
                        AuthorsTextBox.Text = ElemList[i].authors;
                        CountryTextBox.Text = ElemList[i].country;
                        MBArtPictureBox.Image = Image.FromFile(ElemList[i].image);
                        MBArtPictureBox.ImageLocation = ElemList[i].image;
                        break;
                    }
                }
            }
        }

        private void BooksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.BooksListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string name = BooksListBox.SelectedItem.ToString();

                for (int i = 0; i < ElemList.Count(); ++i)
                {
                    if (name == ElemList[i].name)
                    {
                        NameTextBox.Text = ElemList[i].name;
                        DescRichTextBox.Text = ElemList[i].description;
                        DateTextBox.Text = ElemList[i].date;
                        AuthorsTextBox.Text = ElemList[i].authors;
                        CountryTextBox.Text = ElemList[i].country;
                        MBArtPictureBox.Image = Image.FromFile(ElemList[i].image);
                        break;
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (NameRadioButton.Checked)
                while (i < ElemList.Count)
                {
                    if (ElemList[i].name == SearchTextBox.Text)
                    {
                        break;
                    }
                    ++i;
                }
            if (DateRadioButton.Checked)
                while (i < ElemList.Count)
                {
                    if (ElemList[i].date == SearchTextBox.Text)
                    {
                        break;
                    }
                    ++i;
                }
            if (AuthorsRadioButton.Checked)
                while (i < ElemList.Count)
                {
                    if (ElemList[i].authors == SearchTextBox.Text)
                    {
                        break;
                    }
                    ++i;
                }
            if (CountryRadioButton.Checked)
                while (i < ElemList.Count)
                {
                    if (ElemList[i].country == SearchTextBox.Text)
                    {
                        break;
                    }
                    ++i;
                }
            NameTextBox.Text = ElemList[i].name;
            DescRichTextBox.Text = ElemList[i].description;
            DateTextBox.Text = ElemList[i].date;
            AuthorsTextBox.Text = ElemList[i].authors;
            CountryTextBox.Text = ElemList[i].country;
            MBArtPictureBox.Image = Image.FromFile(ElemList[i].image);
        }
    }
}
