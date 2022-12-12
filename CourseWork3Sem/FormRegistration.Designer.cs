namespace CourseWork3Sem
{
    partial class FormRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPassportID = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Адрес проживания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Улица:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "дом:";
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(162, 306);
            this.mtxtPhoneNumber.Mask = "(999) 000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.mtxtPhoneNumber.TabIndex = 10;
            // 
            // mtxtPassportID
            // 
            this.mtxtPassportID.Location = new System.Drawing.Point(67, 158);
            this.mtxtPassportID.Mask = "000000";
            this.mtxtPassportID.Name = "mtxtPassportID";
            this.mtxtPassportID.Size = new System.Drawing.Size(100, 22);
            this.mtxtPassportID.TabIndex = 11;
            this.mtxtPassportID.ValidatingType = typeof(int);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(113, 398);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(166, 40);
            this.btnRegistration.TabIndex = 13;
            this.btnRegistration.Text = "Зарегистрироваться";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 354);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 19;
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(233, 243);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(100, 22);
            this.txtHouseNumber.TabIndex = 20;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(67, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 22;
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(303, 77);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(100, 22);
            this.txtPatronymic.TabIndex = 23;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(81, 243);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 24;
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.Location = new System.Drawing.Point(372, 398);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(95, 39);
            this.btnReturnBack.TabIndex = 25;
            this.btnReturnBack.Text = "Назад";
            this.btnReturnBack.UseVisualStyleBackColor = true;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.btnReturnBack);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.mtxtPassportID);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistration";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistration_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtxtPassportID;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button btnReturnBack;
    }
}