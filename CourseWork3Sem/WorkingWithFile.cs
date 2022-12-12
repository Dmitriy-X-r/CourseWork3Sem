using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWork3Sem
{
    abstract class WorkingWithFile
    {
        public string DBFilepath { get; private set; }
        private string fileNameForReaders = "C:/Users/user/Desktop/Readers.txt";
        private string fileNameForAllBooks = "C:/Users/user/Desktop/AllBooks.txt";
        private string fileNameForAvailableBooks = "C:/Users/user/Desktop/AvailableBooks.txt";
        private string fileNameForDebtors = "C:/Users/user/Desktop/Debtors.txt";
        private string fileNameForAdmin = "C:/Users/user/Desktop/Admin.txt";

        public void OpenOrCreatFile(string nameFile)
        {
            DBFilepath = nameFile;
            if (File.Exists(DBFilepath) == false)
            {
                var file = File.Create(DBFilepath);
                file.Close();
            }
            else
                Console.WriteLine("Файл уже создан");
        }

        public string GetFileNameForReaders()
        {
            return fileNameForReaders;
        }
        public string GetFileNameForAllBooks()
        {
            return fileNameForAllBooks;
        }
        public string GetFileNameForDebtors()
        {
            return fileNameForDebtors;
        }
        public string GetFileNameForAvailableBooks()
        {
            return fileNameForAvailableBooks;
        }
        public string GetFileNameForAdmin()
        {
            return fileNameForAdmin;
        }
    }
}
