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

        Search srh_form = new Search();
        public List<MovieBookData> ElemList;

        public bool info_form_flag = false;

        string filePath = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            srh_form.Owner = this;


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
            srh_form.SearchListBox.Items.Clear();
            srh_form.Hide();
            MoviesListBox.ClearSelected();
            BooksListBox.ClearSelected();
            if (NameTextBox.Text != "")
            {
                if (GlobalTabControl.SelectedIndex == 0)
                {
                    for (int i = 0; i < MoviesListBox.Items.Count; ++i)
                        if (MoviesListBox.Items[i].ToString() == NameTextBox.Text)
                        {
                            MessageBox.Show("Element with this name already exists");
                            filePath = "";
                            NameTextBox.Text = "";
                            DescRichTextBox.Text = "";
                            DateTextBox.Text = "";
                            AuthorsTextBox.Text = "";
                            CountryTextBox.Text = "";
                            MBArtPictureBox.Image = Image.FromFile("images\\clear_image.jpg");
                            MBArtPictureBox.ImageLocation = "images\\clear_image.jpg";
                            return;
                        }


                    int shift;
                    string short_filepath;

                    if (filePath != "")
                    {
                        shift = filePath.IndexOf("images\\");
                        short_filepath = filePath.Substring(shift, filePath.Length - shift);
                    }
                    else
                    {
                        short_filepath = "images\\clear_image.jpg";
                    }
                    MovieBookData temp = new MovieBookData(NameTextBox.Text, DescRichTextBox.Text, DateTextBox.Text,
                    AuthorsTextBox.Text, CountryTextBox.Text, short_filepath, Convert.ToInt32(GlobalTabControl.SelectedIndex));
                    ElemList.Add(temp);
                    MoviesListBox.Items.Add(NameTextBox.Text);
                }

                if (GlobalTabControl.SelectedIndex == 1)
                {
                    for (int i = 0; i < BooksListBox.Items.Count; ++i)
                        if (BooksListBox.Items[i].ToString() == NameTextBox.Text)
                        {
                            MessageBox.Show("Element with this name already exists");
                            filePath = "";
                            NameTextBox.Text = "";
                            DescRichTextBox.Text = "";
                            DateTextBox.Text = "";
                            AuthorsTextBox.Text = "";
                            CountryTextBox.Text = "";
                            MBArtPictureBox.Image = Image.FromFile("images\\clear_image.jpg");
                            MBArtPictureBox.ImageLocation = "images\\clear_image.jpg";
                            return;
                        }

                    int shift;
                    string short_filepath;

                    if (filePath != "")
                    {
                        shift = filePath.IndexOf("images\\");
                        short_filepath = filePath.Substring(shift, filePath.Length - shift);
                    }
                    else
                    {
                        short_filepath = "images\\clear_image.jpg";
                    }

                    MovieBookData temp = new MovieBookData(NameTextBox.Text, DescRichTextBox.Text, DateTextBox.Text,
                    AuthorsTextBox.Text, CountryTextBox.Text, short_filepath, Convert.ToInt32(GlobalTabControl.SelectedIndex));
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
            filePath = "";
            NameTextBox.Text = "";
            DescRichTextBox.Text = "";
            DateTextBox.Text = "";
            AuthorsTextBox.Text = "";
            CountryTextBox.Text = "";
            MBArtPictureBox.Image = Image.FromFile("images\\clear_image.jpg");
            MBArtPictureBox.ImageLocation = "images\\clear_image.jpg";
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {

            srh_form.SearchListBox.Items.Clear();
            srh_form.Hide();

            if (MoviesListBox.Items.Count == 0 && BooksListBox.Items.Count == 0)
            {
                return;
            }

            try
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
                    MBArtPictureBox.Image = Image.FromFile("images\\clear_image.jpg");

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
                    MBArtPictureBox.Image = Image.FromFile("images\\clear_image.jpg");

                    BooksListBox.Items.Remove(BooksListBox.SelectedItem);
                    string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                    StreamWriter file = File.CreateText("data.json");
                    file.WriteLine(json_temp);
                    file.Close();
                    MessageBox.Show("Item deleted!");
                }
            }
            catch
            {

            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                srh_form.SearchListBox.Items.Clear();
                srh_form.Hide();
                if (MoviesListBox.Items.Count == 0 && BooksListBox.Items.Count == 0)
                    return;

                if (GlobalTabControl.SelectedIndex == 0)
                {
                    for (int i = 0; i < ElemList.Count; ++i)
                        if (ElemList[i].name == MoviesListBox.SelectedItem.ToString() && ElemList[i].type_flag == 0)
                        {

                            ElemList[i].name = NameTextBox.Text;
                            ElemList[i].description = DescRichTextBox.Text;
                            ElemList[i].date = DateTextBox.Text;
                            ElemList[i].authors = AuthorsTextBox.Text;
                            ElemList[i].country = CountryTextBox.Text;

                            filePath = MBArtPictureBox.ImageLocation;
                            int shift = filePath.IndexOf("images\\");
                            ElemList[i].image = filePath.Substring(shift, filePath.Length - shift);

                            string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                            StreamWriter file = File.CreateText("data.json");
                            file.WriteLine(json_temp);
                            file.Close();
                            MessageBox.Show("Completed!");

                            MoviesListBox.Items.Clear();

                            for (int j = 0; j < ElemList.Count; ++j)
                            {
                                if (ElemList[j].type_flag == 0)
                                {
                                    MoviesListBox.Items.Add(ElemList[j].name);
                                }
                            }

                            return;
                        }
                }

                if (GlobalTabControl.SelectedIndex == 1)
                {
                    for (int i = 0; i < ElemList.Count; ++i)
                    {
                        if (ElemList[i].name == BooksListBox.SelectedItem.ToString() && ElemList[i].type_flag == 1)
                        {
                            ElemList[i].name = NameTextBox.Text;
                            ElemList[i].description = DescRichTextBox.Text;
                            ElemList[i].date = DateTextBox.Text;
                            ElemList[i].authors = AuthorsTextBox.Text;
                            ElemList[i].country = CountryTextBox.Text;

                            filePath = MBArtPictureBox.ImageLocation;
                            int shift = filePath.IndexOf("images\\");
                            ElemList[i].image = filePath.Substring(shift, filePath.Length - shift);

                            string json_temp = JsonSerializer.Serialize(ElemList, typeof(List<MovieBookData>));
                            StreamWriter file = File.CreateText("data.json");
                            file.WriteLine(json_temp);
                            file.Close();
                            MessageBox.Show("Completed!");

                            BooksListBox.Items.Clear();

                            for (int j = 0; j < ElemList.Count; ++j)
                            {
                                if (ElemList[j].type_flag == 1)
                                {
                                    BooksListBox.Items.Add(ElemList[j].name);
                                }
                            }
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Choose element");
            }
        }



        private void LoadNewButton_Click(object sender, EventArgs e)
        {

            srh_form.SearchListBox.Items.Clear();
            srh_form.Hide();
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
            if (filePath == "")
            {
                MessageBox.Show("Field if empty");
                return;
            }
            try
            {
                MBArtPictureBox.Image = Image.FromFile(filePath);
                MBArtPictureBox.ImageLocation = filePath;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("To big file!");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            srh_form.SearchListBox.Items.Clear();
            srh_form.Hide();
            MessageBox.Show("Help");
        }

        private void MoviesListBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void MoviesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void BooksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        //rich sort
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
                return;
            srh_form.Show();
            try
            {
                int i = 0;
                if (NameRadioButton.Checked)
                    while (i < ElemList.Count)
                    {
                        if (ElemList[i].type_flag == GlobalTabControl.SelectedIndex)
                            if (ElemList[i].name.IndexOf(SearchTextBox.Text) != -1)
                                srh_form.SearchListBox.Items.Add(ElemList[i].name);
                        ++i;
                    }
                if (DateRadioButton.Checked)
                    while (i < ElemList.Count)
                    {
                        if (ElemList[i].type_flag == GlobalTabControl.SelectedIndex)
                            if (ElemList[i].date.IndexOf(SearchTextBox.Text) != -1)
                                srh_form.SearchListBox.Items.Add(ElemList[i].name);
                        ++i;
                    }
                if (AuthorsRadioButton.Checked)
                {
                    while (i < ElemList.Count)
                    {
                        if (ElemList[i].type_flag == GlobalTabControl.SelectedIndex)
                        {
                            if (ElemList[i].authors.IndexOf(SearchTextBox.Text) != -1)
                            {
                                srh_form.SearchListBox.Items.Add(ElemList[i].name);
                            }
                        }
                        ++i;

                    }
                }
                if (CountryRadioButton.Checked)
                {
                    while (i < ElemList.Count)
                    {
                        //MessageBox.Show("a1");
                        if (ElemList[i].type_flag == GlobalTabControl.SelectedIndex)
                        {
                            //MessageBox.Show("a2");
                            //MessageBox.Show(ElemList[i].country);
                            if (ElemList[i].country.IndexOf(SearchTextBox.Text) != -1)
                            {
                                srh_form.SearchListBox.Items.Add(ElemList[i].name);
                            }
                        }
                        ++i;
                    }
                }
            }
            catch
            {

            }
        }

        private void MoviesListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = this.MoviesListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string name = "";

                name = MoviesListBox.SelectedItem.ToString();

                for (int i = 0; i < ElemList.Count(); ++i)
                {
                    if (name == ElemList[i].name && ElemList[i].type_flag == 0)
                    {
                        filePath = ElemList[i].image;
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

        private void BooksListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = this.BooksListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string name = BooksListBox.SelectedItem.ToString();

                for (int i = 0; i < ElemList.Count(); ++i)
                {
                    if (name == ElemList[i].name && ElemList[i].type_flag == 1)
                    {
                        filePath = ElemList[i].image;
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

        private void MBArtPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void GlobalTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            DescRichTextBox.Text = "";
            DateTextBox.Text = "";
            AuthorsTextBox.Text = "";
            CountryTextBox.Text = "";
            MBArtPictureBox.Image = Image.FromFile("images\\clear_image.jpg");
            MoviesListBox.ClearSelected();
            BooksListBox.ClearSelected();

        }
    }
}
