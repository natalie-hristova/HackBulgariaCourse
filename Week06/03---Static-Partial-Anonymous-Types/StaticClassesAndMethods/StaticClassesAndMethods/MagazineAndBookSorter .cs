using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    static class MagazineAndBookSorter
    {
        class Edition
        {
            public string EditionName { get; set; }
            public int Order { get; set; }

            public Edition(Book book)
            {
                this.EditionName = book.Name;
                this.Order = book.Id;
            }

            public Edition(Magazine magazine)
            {
                this.EditionName = magazine.Title;
                this.Order = magazine.ISBN;
            }
        }
        public static List<string> Sort(List<Book> books, List<Magazine> magazines)
        {
            List<string> returnList = new List<string>(books.Count + magazines.Count);
            List<Edition> papers = new List<Edition>(books.Count + magazines.Count);
            for (int i = 0; i < books.Count; i++)
            {
                papers.Add(new Edition(books[i]));
            }
            for (int i = 0; i < magazines.Count; i++)
            {
                papers.Add(new Edition(magazines[i]));
            }

           return papers.OrderBy(a => a.EditionName).ThenBy(a => a.Order).Select(a=>a.EditionName).ToList();

          
        }


    }
}
