using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork3Sem
{
    public partial class FormAdmin : Form
    {
        private WorkingWithDB DB = new WorkingWithDB();
        private string filePath;
        public FormAdmin()
        {
            InitializeComponent();         
           
            filePath = DB.GetFileNameForDebtors();
            DB.OpenOrCreatFile(filePath);

            WorkingWithDB.IsAdmin = true;
            List<Debtor> debtors = DB.ReadAllFromDB<Debtor>();

            if(debtors.Count == 0)
                listBoxDebtors.Items.Add("Нет должников");
            foreach (var debtor in debtors)
                listBoxDebtors.Items.Add(debtor);

            filePath = DB.GetFileNameForAllBooks();
            DB.OpenOrCreatFile(filePath);

            List<Book> books = DB.ReadAllFromDB<Book>();
            //Book[] booksCopy = books.ToArray();
            //List<Book>.Sort(books);           

            if (books.Count == 0)
                listBoxBookList.Items.Add("Беда, нет книг!");
            foreach (var book in books)
                listBoxBookList.Items.Add(book);
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text.Length == 0)
            {
                MessageBox.Show("Пустое поле \"Название книги\"");
                return;
            }

            if(txtAuthor.Text.Length == 0)
            {
                MessageBox.Show("Пустое поле \"Автор\"");
                return;
            }

            if(txtAuthor.Text.Length < 5)
            {
                MessageBox.Show("Некорректное поле \"Автор\"");
                return;
            }

            filePath = DB.GetFileNameForAllBooks();
            DB.OpenOrCreatFile(filePath);
            Book newBook;

            try 
            {
                newBook = new Book(txtBookName.Text, txtAuthor.Text);
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
                return;
            }

            DB.SaveToDB<Book>(newBook);

            filePath = DB.GetFileNameForAvailableBooks();
            DB.OpenOrCreatFile(filePath);
            DB.SaveToDB<Book>(newBook);

            listBoxBookList.Items.Add(newBook);

            txtBookName.Text = "";
            txtAuthor.Text = "";
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
        }

        private void btnAddBooksFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Library File";
            openFileDialog.Filter = "Library files|*.txt";
            openFileDialog.InitialDirectory = @"C:";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Book> externalBooks;

                try
                {
                    DB.OpenOrCreatFile(openFileDialog.FileName);
                    externalBooks = DB.ReadAllFromDB<Book>();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Некорректные данные в файле" + ex.Message); 
                    return;
                }

                if (externalBooks.Count == 0)
                {
                    MessageBox.Show("Пустой файл");
                    return;
                }

                DB.OpenOrCreatFile(DB.GetFileNameForAllBooks());
                List<Book> allBooks = DB.ReadAllFromDB<Book>();
                allBooks.AddRange(externalBooks);

                DB.SaveToDB<Book>(allBooks);

                DB.OpenOrCreatFile(DB.GetFileNameForAvailableBooks());
                List<Book> availableBooks = DB.ReadAllFromDB<Book>();
                availableBooks.AddRange(externalBooks);

                DB.SaveToDB<Book>(availableBooks);

                foreach (var book in externalBooks)
                    listBoxBookList.Items.Add(book);
            }
        }
    }
}
