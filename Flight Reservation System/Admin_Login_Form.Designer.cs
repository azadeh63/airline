namespace Flight_Reservation_System
{
    partial class Admin_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_Form));
            this.pic_Admin = new System.Windows.Forms.PictureBox();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_UserN = new System.Windows.Forms.TextBox();
            this.btn_AdminExit = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Admin
            // 
            this.pic_Admin.Image = ((System.Drawing.Image)(resources.GetObject("pic_Admin.Image")));
            this.pic_Admin.Location = new System.Drawing.Point(27, 53);
            this.pic_Admin.Name = "pic_Admin";
            this.pic_Admin.Size = new System.Drawing.Size(74, 63);
            this.pic_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Admin.TabIndex = 23;
            this.pic_Admin.TabStop = false;
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.AutoEllipsis = true;
            this.btn_AdminLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.Location = new System.Drawing.Point(62, 178);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(134, 40);
            this.btn_AdminLogin.TabIndex = 22;
            this.btn_AdminLogin.Text = "Login";
            this.btn_AdminLogin.UseVisualStyleBackColor = true;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(202, 102);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(190, 31);
            this.textBox_Pass.TabIndex = 21;
            // 
            // textBox_UserN
            // 
            this.textBox_UserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserN.Location = new System.Drawing.Point(202, 34);
            this.textBox_UserN.Name = "textBox_UserN";
            this.textBox_UserN.Size = new System.Drawing.Size(190, 31);
            this.textBox_UserN.TabIndex = 20;
            // 
            // btn_AdminExit
            // 
            this.btn_AdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminExit.Location = new System.Drawing.Point(258, 178);
            this.btn_AdminExit.Name = "btn_AdminExit";
            this.btn_AdminExit.Size = new System.Drawing.Size(133, 40);
            this.btn_AdminExit.TabIndex = 19;
            this.btn_AdminExit.Text = "Exit";
            this.btn_AdminExit.UseVisualStyleBackColor = true;
            this.btn_AdminExit.Click += new System.EventHandler(this.btn_AdminExit_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(107, 109);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 18;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(107, 41);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(89, 20);
            this.lbl_UserName.TabIndex = 17;
            this.lbl_UserName.Text = "User Name";
            // 
            // Admin_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 285);
            this.Controls.Add(this.pic_Admin);
            this.Controls.Add(this.btn_AdminLogin);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_UserN);
            this.Controls.Add(this.btn_AdminExit);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login_Form";
    
            ((System.ComponentModel.ISupportInitialize)(this.pic_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Admin;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_UserN;
        private System.Windows.Forms.Button btn_AdminExit;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
    }
}