﻿namespace MovieRental
{
    partial class EmployeeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cidtext = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Atype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CreditCardNumber = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.AccountCreationDate = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Allcustomer = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ratelabel = new System.Windows.Forms.Label();
            this.rateTextbox = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Allcustomer);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.update);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.searchBtn);
            this.panel4.Controls.Add(this.searchTxt);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(48, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 615);
            this.panel4.TabIndex = 29;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(562, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 38);
            this.button6.TabIndex = 32;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(562, 90);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 41);
            this.update.TabIndex = 31;
            this.update.Text = "Edit";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(528, 221);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Today\'s Order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add New User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(521, 11);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search Customer";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(415, 11);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 21);
            this.searchTxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(3, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 340);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.cidtext);
            this.panel2.Controls.Add(this.CID);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.st);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 342);
            this.panel2.TabIndex = 47;
            // 
            // cidtext
            // 
            this.cidtext.Enabled = false;
            this.cidtext.Location = new System.Drawing.Point(384, 33);
            this.cidtext.Name = "cidtext";
            this.cidtext.Size = new System.Drawing.Size(92, 21);
            this.cidtext.TabIndex = 49;
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CID.Location = new System.Drawing.Point(408, 5);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(39, 19);
            this.CID.TabIndex = 48;
            this.CID.Text = "CID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rateTextbox);
            this.panel3.Controls.Add(this.ratelabel);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.Atype);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.CreditCardNumber);
            this.panel3.Controls.Add(this.EmailAddress);
            this.panel3.Controls.Add(this.Telephone);
            this.panel3.Controls.Add(this.ZipCode);
            this.panel3.Controls.Add(this.AccountCreationDate);
            this.panel3.Controls.Add(this.State);
            this.panel3.Controls.Add(this.City);
            this.panel3.Controls.Add(this.Street);
            this.panel3.Location = new System.Drawing.Point(29, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 221);
            this.panel3.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(324, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Plan";
            // 
            // Atype
            // 
            this.Atype.FormattingEnabled = true;
            this.Atype.Items.AddRange(new object[] {
            "limited",
            "unlimited1",
            "unlimited2",
            "unlimited3"});
            this.Atype.Location = new System.Drawing.Point(322, 134);
            this.Atype.Name = "Atype";
            this.Atype.Size = new System.Drawing.Size(147, 20);
            this.Atype.TabIndex = 46;
            this.Atype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(61, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "credit card number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(61, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(61, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(319, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Account Creation Date";
            // 
            // CreditCardNumber
            // 
            this.CreditCardNumber.Enabled = false;
            this.CreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreditCardNumber.Location = new System.Drawing.Point(65, 197);
            this.CreditCardNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreditCardNumber.Name = "CreditCardNumber";
            this.CreditCardNumber.Size = new System.Drawing.Size(252, 23);
            this.CreditCardNumber.TabIndex = 35;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Enabled = false;
            this.EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EmailAddress.Location = new System.Drawing.Point(65, 134);
            this.EmailAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(170, 23);
            this.EmailAddress.TabIndex = 34;
            // 
            // Telephone
            // 
            this.Telephone.Enabled = false;
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Telephone.Location = new System.Drawing.Point(65, 69);
            this.Telephone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(170, 23);
            this.Telephone.TabIndex = 33;
            // 
            // ZipCode
            // 
            this.ZipCode.Enabled = false;
            this.ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZipCode.Location = new System.Drawing.Point(389, 9);
            this.ZipCode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(80, 23);
            this.ZipCode.TabIndex = 32;
            // 
            // AccountCreationDate
            // 
            this.AccountCreationDate.Enabled = false;
            this.AccountCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountCreationDate.Location = new System.Drawing.Point(322, 69);
            this.AccountCreationDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AccountCreationDate.Name = "AccountCreationDate";
            this.AccountCreationDate.Size = new System.Drawing.Size(147, 23);
            this.AccountCreationDate.TabIndex = 36;
            // 
            // State
            // 
            this.State.Enabled = false;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.State.Location = new System.Drawing.Point(279, 9);
            this.State.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(80, 23);
            this.State.TabIndex = 31;
            // 
            // City
            // 
            this.City.Enabled = false;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.City.HideSelection = false;
            this.City.Location = new System.Drawing.Point(171, 9);
            this.City.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(80, 23);
            this.City.TabIndex = 30;
            // 
            // Street
            // 
            this.Street.Enabled = false;
            this.Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Street.Location = new System.Drawing.Point(65, 9);
            this.Street.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(80, 23);
            this.Street.TabIndex = 29;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(376, 306);
            this.save.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 29);
            this.save.TabIndex = 46;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(415, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "ZipCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(305, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(196, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(213, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Last Name";
            // 
            // LastName
            // 
            this.LastName.Enabled = false;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastName.Location = new System.Drawing.Point(216, 31);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(80, 23);
            this.LastName.TabIndex = 28;
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.st.Location = new System.Drawing.Point(89, 61);
            this.st.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(46, 17);
            this.st.TabIndex = 27;
            this.st.Text = "Street";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(89, 5);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 17);
            this.name.TabIndex = 26;
            this.name.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Enabled = false;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FirstName.Location = new System.Drawing.Point(93, 31);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(80, 23);
            this.FirstName.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(218, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(70, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "Mailing Address: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(140, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "CustomerName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(68, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Mailing List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Suggest Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Allcustomer
            // 
            this.Allcustomer.Location = new System.Drawing.Point(15, 3);
            this.Allcustomer.Name = "Allcustomer";
            this.Allcustomer.Size = new System.Drawing.Size(88, 36);
            this.Allcustomer.TabIndex = 33;
            this.Allcustomer.Text = "All Customer";
            this.Allcustomer.UseVisualStyleBackColor = true;
            this.Allcustomer.Click += new System.EventHandler(this.Allcustomer_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(180, 306);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 28);
            this.add.TabIndex = 50;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ratelabel
            // 
            this.ratelabel.AutoSize = true;
            this.ratelabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ratelabel.Location = new System.Drawing.Point(344, 169);
            this.ratelabel.Name = "ratelabel";
            this.ratelabel.Size = new System.Drawing.Size(40, 16);
            this.ratelabel.TabIndex = 48;
            this.ratelabel.Text = "Rate";
            // 
            // rateTextbox
            // 
            this.rateTextbox.Location = new System.Drawing.Point(342, 196);
            this.rateTextbox.Name = "rateTextbox";
            this.rateTextbox.Size = new System.Drawing.Size(126, 21);
            this.rateTextbox.TabIndex = 49;
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel4);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(862, 656);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccountCreationDate;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreditCardNumber;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.TextBox ZipCode;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox cidtext;
        private System.Windows.Forms.Label CID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Atype;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Allcustomer;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox rateTextbox;
        private System.Windows.Forms.Label ratelabel;
    }
}
