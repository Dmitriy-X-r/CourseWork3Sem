using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    class Debtor : IComparable
    {
        public Reader reader { get; }
        public List<Book> books { get; }
     

        public Debtor(Reader reader, List<Book> books)
        {
            this.reader = reader;
            this.books = books;
        }

        public int CompareTo(object obj)
        {
            if (obj is Debtor debtor)
                return reader.FullName.CompareTo(debtor.reader.FullName);
            else
                throw new ArgumentException("Некорректное значение параметра");
        }

        public override string ToString()
        {
            string str = "";
            if (WorkingWithDB.IsAdmin)
                str = ($"{reader.FullName}, {reader.PhoneNumber} - ");
            
            foreach (var book in books)
                str += ($"{book.NameBook} ({book.Author})\n");

            return str;
        }
    }
}
