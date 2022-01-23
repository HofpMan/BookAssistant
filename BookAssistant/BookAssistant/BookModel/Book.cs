using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAssistant
{
    public class ListBock
    {
        public int id { get; set; }
        public string NameBook { get; set; }
        public string Author{ get; set; }
        public int YearOfPublication { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"Книга: {Author}, {NameBook}.\nРік випуску:{YearOfPublication}.\nЖанр:{Genre}\n";
        }
    }
}
