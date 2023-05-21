using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MovieManager
{
    [Serializable]
    public class MovieBookData
    {
        public string name { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string authors { get; set; }
        public string country { get; set; }
        public string image { get; set; }
        public int type_flag { get; set; }



        public MovieBookData(string new_name, string new_description, string new_date, string new_authors,
            string new_country, string new_image, int new_type_flag) 
        {
            name = new_name;
            description = new_description;
            date = new_date;
            authors = new_authors;
            country = new_country;
            image = new_image;
            type_flag = new_type_flag;
        }

        [JsonConstructor]
        public MovieBookData()
        {

        }
        
        
        //public string Name { get => name; set => name = value; }
        //public string Description { get => description; set => description = value; }
        //public string Date { get => date; set => date = value; }
        //public string Authors { get => authors; set => authors = value; }
        //public string Country { get => country; set => country = value; }
        //public string Image { get => image; set => image = value; }
        //public int Type_flag { get => type_flag; set => type_flag = value; }
    }
}
