namespace Flight_Reservation_System
{
    partial class Admin_Panel_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBox_SearchFlight = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddFlightInfo = new System.Windows.Forms.Button();
            this.btn_ClearAddInfo = new System.Windows.Forms.Button();
            this.lbl_FlightCapacity = new System.Windows.Forms.Label();
            this.txtBox_Capacity = new System.Windows.Forms.TextBox();
            this.lbl_FlightPrice = new System.Windows.Forms.Label();
            this.txtBox_FlightPrice = new System.Windows.Forms.TextBox();
            this.lbl_FlightID = new System.Windows.Forms.Label();
            this.txtBox_FlightId = new System.Windows.Forms.TextBox();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.cdr_FlightDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbBox_FlightClass = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.txtBox_Destination = new System.Windows.Forms.TextBox();
            this.lbl_From = new System.Windows.Forms.Label();
            this.txtBox_Source = new System.Windows.Forms.TextBox();
            this.picBox_AddInfo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBox_AddAdmin = new System.Windows.Forms.PictureBox();
            this.btn_AddAdmin = new System.Windows.Forms.Button();
            this.btn_ClearAddAdmin = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_UserN = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_SearchFlight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AddInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AddAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBox_SearchFlight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search and Edit Flight Information";
            // 
            // picBox_SearchFlight
            // 
            this.picBox_SearchFlight.Image = ((System.Drawing.Image)(resources.GetObject("picBox_SearchFlight.Image")));
            this.picBox_SearchFlight.Location = new System.Drawing.Point(26, 38);
            this.picBox_SearchFlight.Name = "picBox_SearchFlight";
            this.picBox_SearchFlight.Size = new System.Drawing.Size(64, 64);
            this.picBox_SearchFlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_SearchFlight.TabIndex = 14;
            this.picBox_SearchFlight.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AddFlightInfo);
            this.groupBox2.Controls.Add(this.btn_ClearAddInfo);
            this.groupBox2.Controls.Add(this.lbl_FlightCapacity);
            this.groupBox2.Controls.Add(this.txtBox_Capacity);
            this.groupBox2.Controls.Add(this.lbl_FlightPrice);
            this.groupBox2.Controls.Add(this.txtBox_FlightPrice);
            this.groupBox2.Controls.Add(this.lbl_FlightID);
            this.groupBox2.Controls.Add(this.txtBox_FlightId);
            this.groupBox2.Controls.Add(this.lbl_Class);
            this.groupBox2.Controls.Add(this.cdr_FlightDateTime);
            this.groupBox2.Controls.Add(this.cmbBox_FlightClass);
            this.groupBox2.Controls.Add(this.lbl_Date);
            this.groupBox2.Controls.Add(this.lbl_to);
            this.groupBox2.Controls.Add(this.txtBox_Destination);
            this.groupBox2.Controls.Add(this.lbl_From);
            this.groupBox2.Controls.Add(this.txtBox_Source);
            this.groupBox2.Controls.Add(this.picBox_AddInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Flight Information";
            // 
            // btn_AddFlightInfo
            // 
            this.btn_AddFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFlightInfo.Location = new System.Drawing.Point(458, 147);
            this.btn_AddFlightInfo.Name = "btn_AddFlightInfo";
            this.btn_AddFlightInfo.Size = new System.Drawing.Size(112, 31);
            this.btn_AddFlightInfo.TabIndex = 35;
            this.btn_AddFlightInfo.Text = "Add";
            this.btn_AddFlightInfo.UseVisualStyleBackColor = true;
            this.btn_AddFlightInfo.Click += new System.EventHandler(this.btn_AddFlightInfo_Click);
            // 
            // btn_ClearAddInfo
            // 
            this.btn_ClearAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearAddInfo.Location = new System.Drawing.Point(595, 147);
            this.btn_ClearAddInfo.Name = "btn_ClearAddInfo";
            this.btn_ClearAddInfo.Size = new System.Drawing.Size(112, 31);
            this.btn_ClearAddInfo.TabIndex = 34;
            this.btn_ClearAddInfo.Text = "&Clear";
            this.btn_ClearAddInfo.UseVisualStyleBackColor = true;
            // 
            // lbl_FlightCapacity
            // 
            this.lbl_FlightCapacity.AutoSize = true;
            this.lbl_FlightCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightCapacity.Location = new System.Drawing.Point(629, 79);
            this.lbl_FlightCapacity.Name = "lbl_FlightCapacity";
            this.lbl_FlightCapacity.Size = new System.Drawing.Size(61, 16);
            this.lbl_FlightCapacity.TabIndex = 33;
            this.lbl_FlightCapacity.Text = "Capacity";
            // 
            // txtBox_Capacity
            // 
            this.txtBox_Capacity.AcceptsReturn = true;
            this.txtBox_Capacity.AcceptsTab = true;
            this.txtBox_Capacity.AccessibleName = "";
            this.txtBox_Capacity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Capacity.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Capacity.Location = new System.Drawing.Point(632, 99);
            this.txtBox_Capacity.Name = "txtBox_Capacity";
            this.txtBox_Capacity.Size = new System.Drawing.Size(75, 26);
            this.txtBox_Capacity.TabIndex = 32;
            this.txtBox_Capacity.Tag = "";
            // 
            // lbl_FlightPrice
            // 
            this.lbl_FlightPrice.AutoSize = true;
            this.lbl_FlightPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightPrice.Location = new System.Drawing.Point(516, 79);
            this.lbl_FlightPrice.Name = "lbl_FlightPrice";
            this.lbl_FlightPrice.Size = new System.Drawing.Size(54, 16);
            this.lbl_FlightPrice.TabIndex = 31;
            this.lbl_FlightPrice.Text = "Price($)";
            // 
            // txtBox_FlightPrice
            // 
            this.txtBox_FlightPrice.AcceptsReturn = true;
            this.txtBox_FlightPrice.AcceptsTab = true;
            this.txtBox_FlightPrice.AccessibleName = "";
            this.txtBox_FlightPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_FlightPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FlightPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBox_FlightPrice.Location = new System.Drawing.Point(519, 99);
            this.txtBox_FlightPrice.Name = "txtBox_FlightPrice";
            this.txtBox_FlightPrice.Size = new System.Drawing.Size(75, 26);
            this.txtBox_FlightPrice.TabIndex = 30;
            this.txtBox_FlightPrice.Tag = "";
            // 
            // lbl_FlightID
            // 
            this.lbl_FlightID.AutoSize = true;
            this.lbl_FlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightID.Location = new System.Drawing.Point(392, 79);
            this.lbl_FlightID.Name = "lbl_FlightID";
            this.lbl_FlightID.Size = new System.Drawing.Size(56, 16);
            this.lbl_FlightID.TabIndex = 29;
            this.lbl_FlightID.Text = "Flight ID";
            // 
            // txtBox_FlightId
            // 
            this.txtBox_FlightId.AcceptsReturn = true;
            this.txtBox_FlightId.AcceptsTab = true;
            this.txtBox_FlightId.AccessibleName = "";
            this.txtBox_FlightId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_FlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FlightId.ForeColor = System.Drawing.Color.Black;
            this.txtBox_FlightId.Location = new System.Drawing.Point(395, 99);
            this.txtBox_FlightId.Name = "txtBox_FlightId";
            this.txtBox_FlightId.Size = new System.Drawing.Size(79, 26);
            this.txtBox_FlightId.TabIndex = 28;
            this.txtBox_FlightId.Tag = "";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(570, 19);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(42, 16);
            this.lbl_Class.TabIndex = 27;
            this.lbl_Class.Text = "Class";
            // 
            // cdr_FlightDateTime
            // 
            this.cdr_FlightDateTime.AllowDrop = true;
            this.cdr_FlightDateTime.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdr_FlightDateTime.Location = new System.Drawing.Point(170, 99);
            this.cdr_FlightDateTime.Name = "cdr_FlightDateTime";
            this.cdr_FlightDateTime.Size = new System.Drawing.Size(205, 26);
            this.cdr_FlightDateTime.TabIndex = 26;
            this.cdr_FlightDateTime.ValueChanged += new System.EventHandler(this.cdr_FlightDate_ValueChanged);
            // 
            // cmbBox_FlightClass
            // 
            this.cmbBox_FlightClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBox_FlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_FlightClass.FormattingEnabled = true;
            this.cmbBox_FlightClass.Items.AddRange(new object[] {
            "Business",
            "Economy",
            "VIP"});
            this.cmbBox_FlightClass.Location = new System.Drawing.Point(573, 37);
            this.cmbBox_FlightClass.MaxDropDownItems = 3;
            this.cmbBox_FlightClass.Name = "cmbBox_FlightClass";
            this.cmbBox_FlightClass.Size = new System.Drawing.Size(134, 28);
            this.cmbBox_FlightClass.Sorted = true;
            this.cmbBox_FlightClass.TabIndex = 21;
            this.cmbBox_FlightClass.SelectedIndexChanged += new System.EventHandler(this.cmbBox_FlightClass_SelectedIndexChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(167, 79);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(97, 16);
            this.lbl_Date.TabIndex = 25;
            this.lbl_Date.Text = "Date and Time";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(368, 19);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 16);
            this.lbl_to.TabIndex = 24;
            this.lbl_to.Text = "TO";
            // 
            // txtBox_Destination
            // 
            this.txtBox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Destination.Location = new System.Drawing.Point(371, 39);
            this.txtBox_Destination.Name = "txtBox_Destination";
            this.txtBox_Destination.Size = new System.Drawing.Size(171, 26);
            this.txtBox_Destination.TabIndex = 23;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(167, 19);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(39, 16);
            this.lbl_From.TabIndex = 22;
            this.lbl_From.Text = "From";
            // 
            // txtBox_Source
            // 
            this.txtBox_Source.AcceptsReturn = true;
            this.txtBox_Source.AcceptsTab = true;
            this.txtBox_Source.AccessibleName = "";
            this.txtBox_Source.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Source.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Source.Location = new System.Drawing.Point(170, 39);
            this.txtBox_Source.Name = "txtBox_Source";
            this.txtBox_Source.Size = new System.Drawing.Size(173, 26);
            this.txtBox_Source.TabIndex = 20;
            this.txtBox_Source.Tag = "";
            this.txtBox_Source.TextChanged += new System.EventHandler(this.txtBox_Source_TextChanged);
            // 
            // picBox_AddInfo
            // 
            this.picBox_AddInfo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_AddInfo.Image")));
            this.picBox_AddInfo.Location = new System.Drawing.Point(28, 61);
            this.picBox_AddInfo.Name = "picBox_AddInfo";
            this.picBox_AddInfo.Size = new System.Drawing.Size(64, 64);
            this.picBox_AddInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AddInfo.TabIndex = 15;
            this.picBox_AddInfo.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBox_AddAdmin);
            this.groupBox3.Controls.Add(this.btn_AddAdmin);
            this.groupBox3.Controls.Add(this.btn_ClearAddAdmin);
            this.groupBox3.Controls.Add(this.textBox_Pass);
            this.groupBox3.Controls.Add(this.textBox_UserN);
            this.groupBox3.Controls.Add(this.lbl_Password);
            this.groupBox3.Controls.Add(this.lbl_UserName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Admin";
            // 
            // picBox_AddAdmin
            // 
            this.picBox_AddAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picBox_AddAdmin.Image")));
            this.picBox_AddAdmin.Location = new System.Drawing.Point(28, 34);
            this.picBox_AddAdmin.Name = "picBox_AddAdmin";
            this.picBox_AddAdmin.Size = new System.Drawing.Size(64, 64);
            this.picBox_AddAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AddAdmin.TabIndex = 13;
            this.picBox_AddAdmin.TabStop = false;
            // 
            // btn_AddAdmin
            // 
            this.btn_AddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAdmin.Location = new System.Drawing.Point(458, 47);
            this.btn_AddAdmin.Name = "btn_AddAdmin";
            this.btn_AddAdmin.Size = new System.Drawing.Size(112, 31);
            this.btn_AddAdmin.TabIndex = 12;
            this.btn_AddAdmin.Text = "Add";
            this.btn_AddAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_ClearAddAdmin
            // 
            this.btn_ClearAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearAddAdmin.Location = new System.Drawing.Point(595, 47);
            this.btn_ClearAddAdmin.Name = "btn_ClearAddAdmin";
            this.btn_ClearAddAdmin.Size = new System.Drawing.Size(112, 31);
            this.btn_ClearAddAdmin.TabIndex = 11;
            this.btn_ClearAddAdmin.Text = "&Clear";
            this.btn_ClearAddAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(223, 73);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(186, 26);
            this.textBox_Pass.TabIndex = 10;
            // 
            // textBox_UserN
            // 
            this.textBox_UserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserN.Location = new System.Drawing.Point(223, 27);
            this.textBox_UserN.Name = "textBox_UserN";
            this.textBox_UserN.Size = new System.Drawing.Size(186, 26);
            this.textBox_UserN.TabIndex = 9;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(128, 80);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(68, 16);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(128, 34);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(77, 16);
            this.lbl_UserName.TabIndex = 7;
            this.lbl_UserName.Text = "User Name";
            // 
            // Admin_Panel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Panel_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_SearchFlight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AddInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AddAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_UserN;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.PictureBox picBox_AddAdmin;
        private System.Windows.Forms.Button btn_AddAdmin;
        private System.Windows.Forms.Button btn_ClearAddAdmin;
        private System.Windows.Forms.PictureBox picBox_SearchFlight;
        private System.Windows.Forms.PictureBox picBox_AddInfo;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.DateTimePicker cdr_FlightDateTime;
        private System.Windows.Forms.ComboBox cmbBox_FlightClass;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.TextBox txtBox_Destination;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.TextBox txtBox_Source;
        private System.Windows.Forms.Label lbl_FlightCapacity;
        private System.Windows.Forms.TextBox txtBox_Capacity;
        private System.Windows.Forms.Label lbl_FlightPrice;
        private System.Windows.Forms.TextBox txtBox_FlightPrice;
        private System.Windows.Forms.Label lbl_FlightID;
        private System.Windows.Forms.TextBox txtBox_FlightId;
        private System.Windows.Forms.Button btn_AddFlightInfo;
        private System.Windows.Forms.Button btn_ClearAddInfo;
    }
}