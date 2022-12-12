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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            registration.Show();
            this.Hide();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            string phoneNumber = "+7" + mtxtPhoneNumber.Text;
            bool flag = false;
            WorkingWithDB DB = new WorkingWithDB();

            string FilePath = DB.GetFileNameForAdmin();
            DB.OpenOrCreatFile(FilePath);
            List<Admin> admins = DB.ReadAllFromDB<Admin>();

            foreach (var admin in admins)
            {
                if (admin.PhoneNumber == phoneNumber && admin.Password == txtPassword.Text)
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    mtxtPhoneNumber.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                    flag = true;
                    break;
                }
            }
            
            if(!flag)
            {
                FilePath = DB.GetFileNameForReaders();
                DB.OpenOrCreatFile(FilePath);
                List<Reader> readers = DB.ReadAllFromDB<Reader>();

                foreach (var reader in readers)
                {
                    if (reader.PhoneNumber == phoneNumber && reader.Password == txtPassword.Text)
                    {
                        FormLibrary formLibrary = new FormLibrary(this);
                        formLibrary.Show();
                        this.Hide();
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    MessageBox.Show("Неверный логин или пароль");

            }
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Close();
        }
    }
}
