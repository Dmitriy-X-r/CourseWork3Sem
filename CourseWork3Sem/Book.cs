using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    class Book : IComparable
    {
        public string NameBook { get; set; }
        public string Author { get; set; }

        public Book(string nameBook, string author)
        {
            NameBook = nameBook;
            Author = author;
        }

        public override string ToString()
        {
            return ($"{NameBook}, {Author} ");
        }

        public int CompareTo(object obj)
        {
            if (obj is Book book)
                return NameBook.CompareTo(book.NameBook);
            else 
                throw new ArgumentException("Некорректное значение параметра");
        }

    }
}
