using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork3Sem
{
    public partial class FormLibrary : Form
    {
        FormAuthorization formAuthorization;
        WorkingWithDB DB = new WorkingWithDB();
       
        Reader thisReader = null;
        Debtor thisDebtor = null;
        int indexDebtor;

        public FormLibrary(FormAuthorization owner)
        {
            InitializeComponent();
            formAuthorization = owner;

            string fileName = DB.GetFileNameForAvailableBooks();
            DB.OpenOrCreatFile(fileName);

            listBoxBookList.ScrollAlwaysVisible = true;

            List<Book> books = DB.ReadAllFromDB<Book>();
            if(books != null)
                books.Sort();

            if (books.Count == 0)
                listBoxBookList.Items.Add("Книг нет в наличии!");

            for (int i = 0; i < books.Count; i++)
                listBoxBookList.Items.Add(books[i]);
            

            DefineTheReader();

            formAuthorization.mtxtPhoneNumber.Text = "";
            formAuthorization.txtPassword.Text = "";



            if (DefineTheDebtor() == true)
            {
                for (int i = 0; i < thisDebtor.books.Count; i++)
                {
                    listBoxDebtorBooks.Items.Add(thisDebtor.books[i]);
                }
            }
               
        }

        private void DefineTheReader()
        {
            string fileName = DB.GetFileNameForReaders();
            DB.OpenOrCreatFile(fileName);


            List<Reader> readers = DB.ReadAllFromDB<Reader>();
            foreach (var reader in readers)
            {
                if (reader.PhoneNumber == "+7" + formAuthorization.mtxtPhoneNumber.Text)
                {
                    thisReader = reader;
                    break;
                }
            }
        }

        private bool DefineTheDebtor()
        {
            string fileName = DB.GetFileNameForDebtors();
            DB.OpenOrCreatFile(fileName);
            int i = 0;

            WorkingWithDB.IsAdmin = true;

            List<Debtor> debtors = DB.ReadAllFromDB<Debtor>();
            foreach (var debtor in debtors)
            {
                if (debtor.reader.PhoneNumber == thisReader.PhoneNumber)
                {
                    thisDebtor = debtor;
                    indexDebtor = i;
                    break;
                }
                i++;
            }

            if (thisDebtor != null)
                return true;
            else
                return false;
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTakeBooks_Click(object sender, EventArgs e)
        {
            if(listBoxBookList.Items.Count == 0)
            {
                MessageBox.Show("Нет книг в наличии");
                return;
            }

            List<Book> books = listBoxBookList.SelectedItems.Cast<Book>().ToList<Book>();

            if (books.Count != 0)
            {
                if (books.Count <= 5)
                {
                    string fileNameForDebtors = DB.GetFileNameForDebtors();
                    DB.OpenOrCreatFile(fileNameForDebtors);

                    if (thisDebtor != null)
                    {
                        for (int j = 0; j < thisDebtor.books.Count; j++)
                            books.Add(thisDebtor.books[j]);

                        if(books.Count > 5)
                        {
                            MessageBox.Show("Невозможно выдать более 5 книг в одни руки");
                            return;
                        }    

                        DB.DeletFromDB<Debtor>(indexDebtor);
                        listBoxDebtorBooks.Items.Clear();
                    }
                 //   string bookReturnDate = DateTime.Now.ToString("yyyy.MM.dd");
                    thisDebtor = new Debtor(thisReader, books);
                    DB.SaveToDB<Debtor>(thisDebtor);

                    //for (int i = 0; i < thisDebtor.books.Count; i++)
                    //{
                    //    listBoxDebtorBooks.Items.Add(thisDebtor.books[i] + "'Вернуть книгу: " + bookReturnDate);
                    //}
                    for (int i = 0; i < thisDebtor.books.Count; i++)
                    {
                        listBoxDebtorBooks.Items.Add(thisDebtor.books[i]);
                    }

                    string fileNameForBooks = DB.GetFileNameForAvailableBooks();
                    DB.OpenOrCreatFile(fileNameForBooks);

                    for (int x = listBoxBookList.SelectedIndices.Count; x > 0; x--)
                    {
                        DB.DeletFromDB<Book>(listBoxBookList.SelectedIndex);
                        listBoxBookList.Items.RemoveAt(listBoxBookList.SelectedIndex);
                    }
                }
                else
                    MessageBox.Show("Невозможно выдать более 5 книг в одни руки"); 
            }
            else
                MessageBox.Show("Вы ничего не выбрали");

        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            if (listBoxDebtorBooks.Items.Count == 0)
            {
                MessageBox.Show("Вы ничего не должны");
                return;
            }

            List<Book> selectedBooks = listBoxDebtorBooks.SelectedItems.Cast<Book>().ToList<Book>();
            List<Book> remainingBooks;
            if (selectedBooks.Count != 0)
            {
                string fileNameForAvailableBooks = DB.GetFileNameForAvailableBooks();
                DB.OpenOrCreatFile(fileNameForAvailableBooks);

                for (int x = listBoxDebtorBooks.SelectedIndices.Count; x > 0; x--)
                {
                   // string bookReturnDate = DateTime.Now.ToString("yyyy.MM.dd");
                    DB.SaveToDB<Book>(listBoxDebtorBooks.SelectedItem);
                    //  listBoxBookList.Items.Add(listBoxDebtorBooks.SelectedItem + "Вернуть книгу: " + bookReturnDate);
                    listBoxBookList.Items.Add(listBoxDebtorBooks.SelectedItem);

                    listBoxDebtorBooks.Items.RemoveAt(listBoxDebtorBooks.SelectedIndex);
                }
                remainingBooks = listBoxDebtorBooks.Items.Cast<Book>().ToList<Book>();

                string fileNameForDebtors = DB.GetFileNameForDebtors();
                DB.OpenOrCreatFile(fileNameForDebtors);
                DB.DeletFromDB<Debtor>(indexDebtor);

                if (listBoxDebtorBooks.Items.Count != 0)
                {
                    thisDebtor = new Debtor(thisReader, remainingBooks);
                    DB.SaveToDB<Debtor>(thisDebtor);
                }
            }
            else
                MessageBox.Show("Вы не выбрали книгу, которую хотите вернуть");
        }

        private void FormLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
        }
    }
}
