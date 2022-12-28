namespace CourseWork3Sem
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBookList = new System.Windows.Forms.ListBox();
            this.btnAddBooksFromFile = new System.Windows.Forms.Button();
            this.listBoxDebtors = new System.Windows.Forms.ListBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerPublicationData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicationHouse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxBookList
            // 
            this.listBoxBookList.FormattingEnabled = true;
            this.listBoxBookList.HorizontalScrollbar = true;
            this.listBoxBookList.ItemHeight = 16;
            this.listBoxBookList.Location = new System.Drawing.Point(12, 29);
            this.listBoxBookList.Name = "listBoxBookList";
            this.listBoxBookList.ScrollAlwaysVisible = true;
            this.listBoxBookList.Size = new System.Drawing.Size(334, 212);
            this.listBoxBookList.TabIndex = 0;
            // 
            // btnAddBooksFromFile
            // 
            this.btnAddBooksFromFile.Location = new System.Drawing.Point(356, 408);
            this.btnAddBooksFromFile.Name = "btnAddBooksFromFile";
            this.btnAddBooksFromFile.Size = new System.Drawing.Size(219, 46);
            this.btnAddBooksFromFile.TabIndex = 1;
            this.btnAddBooksFromFile.Text = "Загрузить книги из файла";
            this.btnAddBooksFromFile.UseVisualStyleBackColor = true;
            this.btnAddBooksFromFile.Click += new System.EventHandler(this.btnAddBooksFromFile_Click);
            // 
            // listBoxDebtors
            // 
            this.listBoxDebtors.FormattingEnabled = true;
            this.listBoxDebtors.HorizontalScrollbar = true;
            this.listBoxDebtors.ItemHeight = 16;
            this.listBoxDebtors.Location = new System.Drawing.Point(451, 29);
            this.listBoxDebtors.Name = "listBoxDebtors";
            this.listBoxDebtors.ScrollAlwaysVisible = true;
            this.listBoxDebtors.Size = new System.Drawing.Size(467, 212);
            this.listBoxDebtors.TabIndex = 3;
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.Location = new System.Drawing.Point(830, 447);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(88, 29);
            this.btnReturnBack.TabIndex = 4;
            this.btnReturnBack.Text = "Выйти";
            this.btnReturnBack.UseVisualStyleBackColor = true;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список должников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список книг в библиотеке";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(24, 279);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(142, 22);
            this.txtBookName.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(206, 279);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(152, 22);
            this.txtAuthor.TabIndex = 9;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(104, 391);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(143, 31);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Автор книги";
            // 
            // dateTimePickerPublicationData
            // 
            this.dateTimePickerPublicationData.Location = new System.Drawing.Point(24, 345);
            this.dateTimePickerPublicationData.Name = "dateTimePickerPublicationData";
            this.dateTimePickerPublicationData.Size = new System.Drawing.Size(151, 22);
            this.dateTimePickerPublicationData.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дата издания книги";
            // 
            // txtPublicationHouse
            // 
            this.txtPublicationHouse.Location = new System.Drawing.Point(206, 345);
            this.txtPublicationHouse.Name = "txtPublicationHouse";
            this.txtPublicationHouse.Size = new System.Drawing.Size(152, 22);
            this.txtPublicationHouse.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Издательство";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPublicationHouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerPublicationData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.listBoxDebtors);
            this.Controls.Add(this.btnAddBooksFromFile);
            this.Controls.Add(this.listBoxBookList);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookList;
        private System.Windows.Forms.Button btnAddBooksFromFile;
        private System.Windows.Forms.ListBox listBoxDebtors;
        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublicationData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublicationHouse;
        private System.Windows.Forms.Label label6;
    }
}