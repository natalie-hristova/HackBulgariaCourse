using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
     class Magazine
    {
        public string Title { get; set; }
        public int ISBN { get; set; }

        public Magazine(string title , int isbn)
        {
            this.Title = title;
            this.ISBN = isbn;
        }
    }
}
