using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    class Book : IComparable
    {
        public string NameBook { get; private set; }
        public string Author { get; private set; }
        public string PublicationData { get; private set; }
        public string PublicationHouse { get; private set; }
        public string ReturningDate { get; set; }
        private bool isHeld = false;

        public Book(string nameBook, string author, string publicationHouse, string publicationData, string returningDate)
        {
            NameBook = nameBook;
            Author = author;
            PublicationHouse = publicationHouse;
            PublicationData = publicationData;
            ReturningDate = returningDate;
        }

        public void IsHeld()
        {
            isHeld = true;
        }

        public override string ToString()
        {
            string str = "";
            str = ($"{NameBook}, {Author}, Издательство: {PublicationHouse}, Дата издания: {PublicationData}");
            if (isHeld == true)
                str += ($", Вернуть книгу до: {ReturningDate}");
            return str;
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
