namespace Flight_Reservation_System
{
    partial class Flight_Search_Form
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cdr_FlightDate = new System.Windows.Forms.DateTimePicker();
            this.btn_SearchFlight = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cmbBox_FlightClass = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.dgd_FlightInfo = new System.Windows.Forms.DataGridView();
            this.cmbBox_Source = new System.Windows.Forms.ComboBox();
            this.cmbBox_Destination = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(645, 291);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(119, 37);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cdr_FlightDate
            // 
            this.cdr_FlightDate.AllowDrop = true;
            this.cdr_FlightDate.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_FlightDate.Location = new System.Drawing.Point(621, 31);
            this.cdr_FlightDate.Name = "cdr_FlightDate";
            this.cdr_FlightDate.Size = new System.Drawing.Size(151, 26);
            this.cdr_FlightDate.TabIndex = 27;
            // 
            // btn_SearchFlight
            // 
            this.btn_SearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchFlight.Location = new System.Drawing.Point(369, 291);
            this.btn_SearchFlight.Name = "btn_SearchFlight";
            this.btn_SearchFlight.Size = new System.Drawing.Size(117, 39);
            this.btn_SearchFlight.TabIndex = 26;
            this.btn_SearchFlight.Text = "&Search";
            this.btn_SearchFlight.UseVisualStyleBackColor = true;
            this.btn_SearchFlight.Click += new System.EventHandler(this.btn_SearchFlight_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(511, 291);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 39);
            this.btn_Clear.TabIndex = 25;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // cmbBox_FlightClass
            // 
            this.cmbBox_FlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_FlightClass.FormattingEnabled = true;
            this.cmbBox_FlightClass.Items.AddRange(new object[] {
            "ECONOMY",
            "BUSINESS",
            "VIP"});
            this.cmbBox_FlightClass.Location = new System.Drawing.Point(369, 31);
            this.cmbBox_FlightClass.MaxDropDownItems = 3;
            this.cmbBox_FlightClass.Name = "cmbBox_FlightClass";
            this.cmbBox_FlightClass.Size = new System.Drawing.Size(108, 28);
            this.cmbBox_FlightClass.TabIndex = 20;
            this.cmbBox_FlightClass.SelectedIndexChanged += new System.EventHandler(this.cmbBox_FlightClass_SelectedIndexChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(617, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 20);
            this.lbl_Date.TabIndex = 24;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(192, 9);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(30, 20);
            this.lbl_to.TabIndex = 23;
            this.lbl_to.Text = "TO";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(8, 9);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(46, 20);
            this.lbl_From.TabIndex = 21;
            this.lbl_From.Text = "From";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(365, 9);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(48, 20);
            this.lbl_Class.TabIndex = 29;
            this.lbl_Class.Text = "Class";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(503, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 26);
            this.textBox1.TabIndex = 30;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(499, 8);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(44, 20);
            this.lbl_Price.TabIndex = 31;
            this.lbl_Price.Text = "Price";
            // 
            // dgd_FlightInfo
            // 
            this.dgd_FlightInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_FlightInfo.Location = new System.Drawing.Point(12, 84);
            this.dgd_FlightInfo.Name = "dgd_FlightInfo";
            this.dgd_FlightInfo.Size = new System.Drawing.Size(760, 187);
            this.dgd_FlightInfo.TabIndex = 32;
            // 
            // cmbBox_Source
            // 
            this.cmbBox_Source.FormattingEnabled = true;
            this.cmbBox_Source.Location = new System.Drawing.Point(12, 32);
            this.cmbBox_Source.Name = "cmbBox_Source";
            this.cmbBox_Source.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Source.TabIndex = 33;
            // 
            // cmbBox_Destination
            // 
            this.cmbBox_Destination.FormattingEnabled = true;
            this.cmbBox_Destination.Location = new System.Drawing.Point(196, 31);
            this.cmbBox_Destination.Name = "cmbBox_Destination";
            this.cmbBox_Destination.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Destination.TabIndex = 34;
            // 
            // Flight_Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 346);
            this.Controls.Add(this.cmbBox_Destination);
            this.Controls.Add(this.cmbBox_Source);
            this.Controls.Add(this.dgd_FlightInfo);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.cdr_FlightDate);
            this.Controls.Add(this.btn_SearchFlight);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cmbBox_FlightClass);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_From);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Flight_Search_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight_Search_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DateTimePicker cdr_FlightDate;
        private System.Windows.Forms.Button btn_SearchFlight;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmbBox_FlightClass;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.DataGridView dgd_FlightInfo;
        private System.Windows.Forms.ComboBox cmbBox_Source;
        private System.Windows.Forms.ComboBox cmbBox_Destination;
    }
}