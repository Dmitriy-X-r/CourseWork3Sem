namespace CourseWork3Sem
{
    partial class FormLibrary
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
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.listBoxBookList = new System.Windows.Forms.ListBox();
            this.btnTakeBooks = new System.Windows.Forms.Button();
            this.listBoxDebtorBooks = new System.Windows.Forms.ListBox();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.Location = new System.Drawing.Point(649, 374);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(91, 36);
            this.btnReturnBack.TabIndex = 0;
            this.btnReturnBack.Text = "Выйти";
            this.btnReturnBack.UseVisualStyleBackColor = true;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // listBoxBookList
            // 
            this.listBoxBookList.FormattingEnabled = true;
            this.listBoxBookList.ItemHeight = 16;
            this.listBoxBookList.Location = new System.Drawing.Point(27, 68);
            this.listBoxBookList.Name = "listBoxBookList";
            this.listBoxBookList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxBookList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxBookList.Size = new System.Drawing.Size(256, 180);
            this.listBoxBookList.TabIndex = 1;
            // 
            // btnTakeBooks
            // 
            this.btnTakeBooks.Location = new System.Drawing.Point(60, 310);
            this.btnTakeBooks.Name = "btnTakeBooks";
            this.btnTakeBooks.Size = new System.Drawing.Size(173, 54);
            this.btnTakeBooks.TabIndex = 2;
            this.btnTakeBooks.Text = "Взять выбранные книги";
            this.btnTakeBooks.UseVisualStyleBackColor = true;
            this.btnTakeBooks.Click += new System.EventHandler(this.btnTakeBooks_Click);
            // 
            // listBoxDebtorBooks
            // 
            this.listBoxDebtorBooks.FormattingEnabled = true;
            this.listBoxDebtorBooks.ItemHeight = 16;
            this.listBoxDebtorBooks.Location = new System.Drawing.Point(369, 68);
            this.listBoxDebtorBooks.MultiColumn = true;
            this.listBoxDebtorBooks.Name = "listBoxDebtorBooks";
            this.listBoxDebtorBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDebtorBooks.Size = new System.Drawing.Size(256, 180);
            this.listBoxDebtorBooks.TabIndex = 3;
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.Location = new System.Drawing.Point(411, 310);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(173, 54);
            this.btnReturnBooks.TabIndex = 4;
            this.btnReturnBooks.Text = "Вернуть выбранные книги";
            this.btnReturnBooks.UseVisualStyleBackColor = true;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Книги, которые есть в наличии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Книги, которые вы должны вернуть";
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnBooks);
            this.Controls.Add(this.listBoxDebtorBooks);
            this.Controls.Add(this.btnTakeBooks);
            this.Controls.Add(this.listBoxBookList);
            this.Controls.Add(this.btnReturnBack);
            this.Name = "FormLibrary";
            this.Text = "FormLibrary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLibrary_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.ListBox listBoxBookList;
        private System.Windows.Forms.Button btnTakeBooks;
        private System.Windows.Forms.ListBox listBoxDebtorBooks;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}