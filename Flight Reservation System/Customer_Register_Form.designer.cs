namespace Flight_Reservation_System
{
    partial class Customer_Register_Form
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CustomerSave = new System.Windows.Forms.Button();
            this.txtBox_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtBox_CustomerLastName = new System.Windows.Forms.TextBox();
            this.cdr_CustomerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtBox_CustomerEmail = new System.Windows.Forms.TextBox();
            this.lal_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_EmailAddress = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_CustomerPassword = new System.Windows.Forms.Label();
            this.txtBox_CustomerPassword = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPasswordConfirm = new System.Windows.Forms.Label();
            this.txtBox_CustomerPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(386, 178);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 38);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(504, 178);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 38);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CustomerSave
            // 
            this.btn_CustomerSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerSave.Location = new System.Drawing.Point(268, 178);
            this.btn_CustomerSave.Name = "btn_CustomerSave";
            this.btn_CustomerSave.Size = new System.Drawing.Size(112, 38);
            this.btn_CustomerSave.TabIndex = 2;
            this.btn_CustomerSave.Text = "&Save";
            this.btn_CustomerSave.UseVisualStyleBackColor = true;
            this.btn_CustomerSave.Click += new System.EventHandler(this.btn_CustomerSave_Click);
            // 
            // txtBox_CustomerFirstName
            // 
            this.txtBox_CustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerFirstName.Location = new System.Drawing.Point(31, 47);
            this.txtBox_CustomerFirstName.Name = "txtBox_CustomerFirstName";
            this.txtBox_CustomerFirstName.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerFirstName.TabIndex = 3;
            this.txtBox_CustomerFirstName.TextChanged += new System.EventHandler(this.txtBox_CustomerFirstName_TextChanged);
            // 
            // txtBox_CustomerLastName
            // 
            this.txtBox_CustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerLastName.Location = new System.Drawing.Point(239, 47);
            this.txtBox_CustomerLastName.Name = "txtBox_CustomerLastName";
            this.txtBox_CustomerLastName.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerLastName.TabIndex = 4;
            // 
            // cdr_CustomerBirthday
            // 
            this.cdr_CustomerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_CustomerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_CustomerBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cdr_CustomerBirthday.Location = new System.Drawing.Point(443, 45);
            this.cdr_CustomerBirthday.Name = "cdr_CustomerBirthday";
            this.cdr_CustomerBirthday.Size = new System.Drawing.Size(168, 26);
            this.cdr_CustomerBirthday.TabIndex = 7;
            this.cdr_CustomerBirthday.Value = new System.DateTime(2020, 10, 3, 0, 0, 0, 0);
            // 
            // txtBox_CustomerEmail
            // 
            this.txtBox_CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerEmail.Location = new System.Drawing.Point(32, 112);
            this.txtBox_CustomerEmail.Name = "txtBox_CustomerEmail";
            this.txtBox_CustomerEmail.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerEmail.TabIndex = 8;
            // 
            // lal_FirstName
            // 
            this.lal_FirstName.AutoSize = true;
            this.lal_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lal_FirstName.Location = new System.Drawing.Point(28, 24);
            this.lal_FirstName.Name = "lal_FirstName";
            this.lal_FirstName.Size = new System.Drawing.Size(81, 20);
            this.lal_FirstName.TabIndex = 9;
            this.lal_FirstName.Text = "Fist Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(235, 24);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(86, 20);
            this.lbl_LastName.TabIndex = 10;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_EmailAddress
            // 
            this.lbl_EmailAddress.AutoSize = true;
            this.lbl_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailAddress.Location = new System.Drawing.Point(28, 89);
            this.lbl_EmailAddress.Name = "lbl_EmailAddress";
            this.lbl_EmailAddress.Size = new System.Drawing.Size(137, 20);
            this.lbl_EmailAddress.TabIndex = 12;
            this.lbl_EmailAddress.Text = "Email (user name)";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(439, 24);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(99, 20);
            this.lbl_Birthday.TabIndex = 13;
            this.lbl_Birthday.Text = "Date of Birth";
            // 
            // lbl_CustomerPassword
            // 
            this.lbl_CustomerPassword.AutoSize = true;
            this.lbl_CustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerPassword.Location = new System.Drawing.Point(236, 89);
            this.lbl_CustomerPassword.Name = "lbl_CustomerPassword";
            this.lbl_CustomerPassword.Size = new System.Drawing.Size(78, 20);
            this.lbl_CustomerPassword.TabIndex = 15;
            this.lbl_CustomerPassword.Text = "Password";
            // 
            // txtBox_CustomerPassword
            // 
            this.txtBox_CustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerPassword.Location = new System.Drawing.Point(239, 112);
            this.txtBox_CustomerPassword.Name = "txtBox_CustomerPassword";
            this.txtBox_CustomerPassword.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerPassword.TabIndex = 14;
            // 
            // lbl_CustomerPasswordConfirm
            // 
            this.lbl_CustomerPasswordConfirm.AutoSize = true;
            this.lbl_CustomerPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerPasswordConfirm.Location = new System.Drawing.Point(433, 89);
            this.lbl_CustomerPasswordConfirm.Name = "lbl_CustomerPasswordConfirm";
            this.lbl_CustomerPasswordConfirm.Size = new System.Drawing.Size(137, 20);
            this.lbl_CustomerPasswordConfirm.TabIndex = 17;
            this.lbl_CustomerPasswordConfirm.Text = "Confirm Password";
            // 
            // txtBox_CustomerPasswordConfirm
            // 
            this.txtBox_CustomerPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerPasswordConfirm.Location = new System.Drawing.Point(436, 112);
            this.txtBox_CustomerPasswordConfirm.Name = "txtBox_CustomerPasswordConfirm";
            this.txtBox_CustomerPasswordConfirm.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerPasswordConfirm.TabIndex = 16;
            // 
            // Customer_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 231);
            this.Controls.Add(this.lbl_CustomerPasswordConfirm);
            this.Controls.Add(this.txtBox_CustomerPasswordConfirm);
            this.Controls.Add(this.lbl_CustomerPassword);
            this.Controls.Add(this.txtBox_CustomerPassword);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_EmailAddress);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lal_FirstName);
            this.Controls.Add(this.txtBox_CustomerEmail);
            this.Controls.Add(this.cdr_CustomerBirthday);
            this.Controls.Add(this.txtBox_CustomerLastName);
            this.Controls.Add(this.txtBox_CustomerFirstName);
            this.Controls.Add(this.btn_CustomerSave);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.MaximizeBox = false;
            this.Name = "Customer_Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registeration Form";
            this.Load += new System.EventHandler(this.Customer_Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_CustomerSave;
        private System.Windows.Forms.TextBox txtBox_CustomerFirstName;
        private System.Windows.Forms.TextBox txtBox_CustomerLastName;
        private System.Windows.Forms.DateTimePicker cdr_CustomerBirthday;
        private System.Windows.Forms.TextBox txtBox_CustomerEmail;
        private System.Windows.Forms.Label lal_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_EmailAddress;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_CustomerPassword;
        private System.Windows.Forms.TextBox txtBox_CustomerPassword;
        private System.Windows.Forms.Label lbl_CustomerPasswordConfirm;
        private System.Windows.Forms.TextBox txtBox_CustomerPasswordConfirm;
    }
}