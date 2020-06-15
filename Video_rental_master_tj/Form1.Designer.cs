namespace Video_rental_master_tj
{
    partial class Form1
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
            this.csRecord = new System.Windows.Forms.Button();
            this.vsRecord = new System.Windows.Forms.Button();
            this.renRecord = new System.Windows.Forms.Button();
            this.csBest = new System.Windows.Forms.Button();
            this.viBest = new System.Windows.Forms.Button();
            this.tjGridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.csInfo_delete = new System.Windows.Forms.Button();
            this.csInfo_update = new System.Windows.Forms.Button();
            this.csInfo_Add = new System.Windows.Forms.Button();
            this.csInfo_City = new System.Windows.Forms.TextBox();
            this.csInfo_Contact = new System.Windows.Forms.TextBox();
            this.csInfo_email = new System.Windows.Forms.TextBox();
            this.csInfo_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viInfo_Plot = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.viInfo_Genre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.viInfo_copies = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.viInfo_delete = new System.Windows.Forms.Button();
            this.viInfo_update = new System.Windows.Forms.Button();
            this.viInfo_add = new System.Windows.Forms.Button();
            this.viInfo_cost = new System.Windows.Forms.TextBox();
            this.viInfo_year = new System.Windows.Forms.TextBox();
            this.viInfo_points = new System.Windows.Forms.TextBox();
            this.viInfo_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReturnDtp = new System.Windows.Forms.DateTimePicker();
            this.IssueDtp = new System.Windows.Forms.DateTimePicker();
            this.delete_movie_info = new System.Windows.Forms.Button();
            this.return_movie_info = new System.Windows.Forms.Button();
            this.issue_movie_info = new System.Windows.Forms.Button();
            this.videorental_ID = new System.Windows.Forms.TextBox();
            this.rentalInfo_csID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tjGridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // csRecord
            // 
            this.csRecord.BackColor = System.Drawing.Color.FloralWhite;
            this.csRecord.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csRecord.Location = new System.Drawing.Point(12, 12);
            this.csRecord.Name = "csRecord";
            this.csRecord.Size = new System.Drawing.Size(152, 33);
            this.csRecord.TabIndex = 0;
            this.csRecord.Text = "All Customers";
            this.csRecord.UseVisualStyleBackColor = false;
            this.csRecord.Click += new System.EventHandler(this.csRecord_Click);
            // 
            // vsRecord
            // 
            this.vsRecord.BackColor = System.Drawing.Color.FloralWhite;
            this.vsRecord.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsRecord.Location = new System.Drawing.Point(170, 12);
            this.vsRecord.Name = "vsRecord";
            this.vsRecord.Size = new System.Drawing.Size(152, 33);
            this.vsRecord.TabIndex = 1;
            this.vsRecord.Text = "All Videos";
            this.vsRecord.UseVisualStyleBackColor = false;
            this.vsRecord.Click += new System.EventHandler(this.vsRecord_Click);
            // 
            // renRecord
            // 
            this.renRecord.BackColor = System.Drawing.Color.FloralWhite;
            this.renRecord.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renRecord.Location = new System.Drawing.Point(337, 12);
            this.renRecord.Name = "renRecord";
            this.renRecord.Size = new System.Drawing.Size(152, 33);
            this.renRecord.TabIndex = 2;
            this.renRecord.Text = "All Rentals";
            this.renRecord.UseVisualStyleBackColor = false;
            this.renRecord.Click += new System.EventHandler(this.renRecord_Click);
            // 
            // csBest
            // 
            this.csBest.BackColor = System.Drawing.Color.FloralWhite;
            this.csBest.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csBest.Location = new System.Drawing.Point(508, 12);
            this.csBest.Name = "csBest";
            this.csBest.Size = new System.Drawing.Size(152, 33);
            this.csBest.TabIndex = 3;
            this.csBest.Text = "Best Customer";
            this.csBest.UseVisualStyleBackColor = false;
            this.csBest.Click += new System.EventHandler(this.csBest_Click);
            // 
            // viBest
            // 
            this.viBest.BackColor = System.Drawing.Color.FloralWhite;
            this.viBest.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viBest.Location = new System.Drawing.Point(664, 12);
            this.viBest.Name = "viBest";
            this.viBest.Size = new System.Drawing.Size(152, 33);
            this.viBest.TabIndex = 4;
            this.viBest.Text = "Best Movie";
            this.viBest.UseVisualStyleBackColor = false;
            this.viBest.Click += new System.EventHandler(this.viBest_Click);
            // 
            // tjGridview
            // 
            this.tjGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tjGridview.Location = new System.Drawing.Point(12, 51);
            this.tjGridview.Name = "tjGridview";
            this.tjGridview.Size = new System.Drawing.Size(978, 182);
            this.tjGridview.TabIndex = 5;
            this.tjGridview.CellBorderStyleChanged += new System.EventHandler(this.tjGridview_CellBorderStyleChanged);
            this.tjGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tjGridview_CellClick);
            this.tjGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tjGridview_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.csInfo_delete);
            this.groupBox1.Controls.Add(this.csInfo_update);
            this.groupBox1.Controls.Add(this.csInfo_Add);
            this.groupBox1.Controls.Add(this.csInfo_City);
            this.groupBox1.Controls.Add(this.csInfo_Contact);
            this.groupBox1.Controls.Add(this.csInfo_email);
            this.groupBox1.Controls.Add(this.csInfo_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // csInfo_delete
            // 
            this.csInfo_delete.BackColor = System.Drawing.Color.FloralWhite;
            this.csInfo_delete.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_delete.Location = new System.Drawing.Point(85, 238);
            this.csInfo_delete.Name = "csInfo_delete";
            this.csInfo_delete.Size = new System.Drawing.Size(152, 48);
            this.csInfo_delete.TabIndex = 9;
            this.csInfo_delete.Text = "Delete Customer";
            this.csInfo_delete.UseVisualStyleBackColor = false;
            this.csInfo_delete.Click += new System.EventHandler(this.csInfo_delete_Click);
            // 
            // csInfo_update
            // 
            this.csInfo_update.BackColor = System.Drawing.Color.FloralWhite;
            this.csInfo_update.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_update.Location = new System.Drawing.Point(164, 180);
            this.csInfo_update.Name = "csInfo_update";
            this.csInfo_update.Size = new System.Drawing.Size(152, 48);
            this.csInfo_update.TabIndex = 8;
            this.csInfo_update.Text = "Update Customer";
            this.csInfo_update.UseVisualStyleBackColor = false;
            this.csInfo_update.Click += new System.EventHandler(this.csInfo_update_Click);
            // 
            // csInfo_Add
            // 
            this.csInfo_Add.BackColor = System.Drawing.Color.FloralWhite;
            this.csInfo_Add.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_Add.Location = new System.Drawing.Point(6, 180);
            this.csInfo_Add.Name = "csInfo_Add";
            this.csInfo_Add.Size = new System.Drawing.Size(152, 48);
            this.csInfo_Add.TabIndex = 7;
            this.csInfo_Add.Text = "Add Customer";
            this.csInfo_Add.UseVisualStyleBackColor = false;
            this.csInfo_Add.Click += new System.EventHandler(this.csInfo_Add_Click);
            // 
            // csInfo_City
            // 
            this.csInfo_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_City.Location = new System.Drawing.Point(112, 134);
            this.csInfo_City.Name = "csInfo_City";
            this.csInfo_City.Size = new System.Drawing.Size(178, 26);
            this.csInfo_City.TabIndex = 7;
            // 
            // csInfo_Contact
            // 
            this.csInfo_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_Contact.Location = new System.Drawing.Point(112, 97);
            this.csInfo_Contact.Name = "csInfo_Contact";
            this.csInfo_Contact.Size = new System.Drawing.Size(178, 26);
            this.csInfo_Contact.TabIndex = 6;
            // 
            // csInfo_email
            // 
            this.csInfo_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_email.Location = new System.Drawing.Point(112, 64);
            this.csInfo_email.Name = "csInfo_email";
            this.csInfo_email.Size = new System.Drawing.Size(178, 26);
            this.csInfo_email.TabIndex = 5;
            // 
            // csInfo_Name
            // 
            this.csInfo_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csInfo_Name.Location = new System.Drawing.Point(112, 30);
            this.csInfo_Name.Name = "csInfo_Name";
            this.csInfo_Name.Size = new System.Drawing.Size(178, 26);
            this.csInfo_Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viInfo_Plot);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.viInfo_Genre);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.viInfo_copies);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.viInfo_delete);
            this.groupBox2.Controls.Add(this.viInfo_update);
            this.groupBox2.Controls.Add(this.viInfo_add);
            this.groupBox2.Controls.Add(this.viInfo_cost);
            this.groupBox2.Controls.Add(this.viInfo_year);
            this.groupBox2.Controls.Add(this.viInfo_points);
            this.groupBox2.Controls.Add(this.viInfo_Name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(363, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 383);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Info";
            // 
            // viInfo_Plot
            // 
            this.viInfo_Plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_Plot.Location = new System.Drawing.Point(112, 230);
            this.viInfo_Plot.Name = "viInfo_Plot";
            this.viInfo_Plot.Size = new System.Drawing.Size(178, 26);
            this.viInfo_Plot.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Plot";
            // 
            // viInfo_Genre
            // 
            this.viInfo_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_Genre.Location = new System.Drawing.Point(112, 198);
            this.viInfo_Genre.Name = "viInfo_Genre";
            this.viInfo_Genre.Size = new System.Drawing.Size(178, 26);
            this.viInfo_Genre.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Genre";
            // 
            // viInfo_copies
            // 
            this.viInfo_copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_copies.Location = new System.Drawing.Point(112, 166);
            this.viInfo_copies.Name = "viInfo_copies";
            this.viInfo_copies.Size = new System.Drawing.Size(178, 26);
            this.viInfo_copies.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Copies";
            // 
            // viInfo_delete
            // 
            this.viInfo_delete.BackColor = System.Drawing.Color.FloralWhite;
            this.viInfo_delete.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_delete.Location = new System.Drawing.Point(91, 329);
            this.viInfo_delete.Name = "viInfo_delete";
            this.viInfo_delete.Size = new System.Drawing.Size(152, 48);
            this.viInfo_delete.TabIndex = 9;
            this.viInfo_delete.Text = "Delete Video";
            this.viInfo_delete.UseVisualStyleBackColor = false;
            this.viInfo_delete.Click += new System.EventHandler(this.viInfo_delete_Click);
            // 
            // viInfo_update
            // 
            this.viInfo_update.BackColor = System.Drawing.Color.FloralWhite;
            this.viInfo_update.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_update.Location = new System.Drawing.Point(164, 275);
            this.viInfo_update.Name = "viInfo_update";
            this.viInfo_update.Size = new System.Drawing.Size(152, 48);
            this.viInfo_update.TabIndex = 8;
            this.viInfo_update.Text = "Update Video";
            this.viInfo_update.UseVisualStyleBackColor = false;
            this.viInfo_update.Click += new System.EventHandler(this.viInfo_update_Click);
            // 
            // viInfo_add
            // 
            this.viInfo_add.BackColor = System.Drawing.Color.FloralWhite;
            this.viInfo_add.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_add.Location = new System.Drawing.Point(6, 275);
            this.viInfo_add.Name = "viInfo_add";
            this.viInfo_add.Size = new System.Drawing.Size(152, 48);
            this.viInfo_add.TabIndex = 7;
            this.viInfo_add.Text = "Add Video";
            this.viInfo_add.UseVisualStyleBackColor = false;
            this.viInfo_add.Click += new System.EventHandler(this.viInfo_add_Click);
            // 
            // viInfo_cost
            // 
            this.viInfo_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_cost.Location = new System.Drawing.Point(112, 134);
            this.viInfo_cost.Name = "viInfo_cost";
            this.viInfo_cost.Size = new System.Drawing.Size(178, 26);
            this.viInfo_cost.TabIndex = 7;
            // 
            // viInfo_year
            // 
            this.viInfo_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_year.Location = new System.Drawing.Point(112, 97);
            this.viInfo_year.Name = "viInfo_year";
            this.viInfo_year.Size = new System.Drawing.Size(178, 26);
            this.viInfo_year.TabIndex = 6;
            this.viInfo_year.TextChanged += new System.EventHandler(this.viInfo_year_TextChanged);
            // 
            // viInfo_points
            // 
            this.viInfo_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_points.Location = new System.Drawing.Point(112, 64);
            this.viInfo_points.Name = "viInfo_points";
            this.viInfo_points.Size = new System.Drawing.Size(178, 26);
            this.viInfo_points.TabIndex = 5;
            // 
            // viInfo_Name
            // 
            this.viInfo_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viInfo_Name.Location = new System.Drawing.Point(112, 30);
            this.viInfo_Name.Name = "viInfo_Name";
            this.viInfo_Name.Size = new System.Drawing.Size(178, 26);
            this.viInfo_Name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Year Realsed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Points Rates";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Video Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReturnDtp);
            this.groupBox3.Controls.Add(this.IssueDtp);
            this.groupBox3.Controls.Add(this.delete_movie_info);
            this.groupBox3.Controls.Add(this.return_movie_info);
            this.groupBox3.Controls.Add(this.issue_movie_info);
            this.groupBox3.Controls.Add(this.videorental_ID);
            this.groupBox3.Controls.Add(this.rentalInfo_csID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(700, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 292);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental  Info";
            // 
            // ReturnDtp
            // 
            this.ReturnDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDtp.Location = new System.Drawing.Point(112, 140);
            this.ReturnDtp.Name = "ReturnDtp";
            this.ReturnDtp.Size = new System.Drawing.Size(178, 20);
            this.ReturnDtp.TabIndex = 11;
            // 
            // IssueDtp
            // 
            this.IssueDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueDtp.Location = new System.Drawing.Point(112, 103);
            this.IssueDtp.Name = "IssueDtp";
            this.IssueDtp.Size = new System.Drawing.Size(178, 20);
            this.IssueDtp.TabIndex = 10;
            // 
            // delete_movie_info
            // 
            this.delete_movie_info.BackColor = System.Drawing.Color.FloralWhite;
            this.delete_movie_info.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_movie_info.Location = new System.Drawing.Point(85, 238);
            this.delete_movie_info.Name = "delete_movie_info";
            this.delete_movie_info.Size = new System.Drawing.Size(152, 48);
            this.delete_movie_info.TabIndex = 9;
            this.delete_movie_info.Text = "Delete Movie";
            this.delete_movie_info.UseVisualStyleBackColor = false;
            this.delete_movie_info.Click += new System.EventHandler(this.delete_movie_info_Click);
            // 
            // return_movie_info
            // 
            this.return_movie_info.BackColor = System.Drawing.Color.FloralWhite;
            this.return_movie_info.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_movie_info.Location = new System.Drawing.Point(164, 180);
            this.return_movie_info.Name = "return_movie_info";
            this.return_movie_info.Size = new System.Drawing.Size(152, 48);
            this.return_movie_info.TabIndex = 8;
            this.return_movie_info.Text = "Return Movie";
            this.return_movie_info.UseVisualStyleBackColor = false;
            this.return_movie_info.Click += new System.EventHandler(this.return_movie_info_Click);
            // 
            // issue_movie_info
            // 
            this.issue_movie_info.BackColor = System.Drawing.Color.FloralWhite;
            this.issue_movie_info.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_movie_info.Location = new System.Drawing.Point(6, 180);
            this.issue_movie_info.Name = "issue_movie_info";
            this.issue_movie_info.Size = new System.Drawing.Size(152, 48);
            this.issue_movie_info.TabIndex = 7;
            this.issue_movie_info.Text = "Issue Movie";
            this.issue_movie_info.UseVisualStyleBackColor = false;
            this.issue_movie_info.Click += new System.EventHandler(this.issue_movie_info_Click);
            // 
            // videorental_ID
            // 
            this.videorental_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videorental_ID.Location = new System.Drawing.Point(112, 64);
            this.videorental_ID.Name = "videorental_ID";
            this.videorental_ID.Size = new System.Drawing.Size(178, 26);
            this.videorental_ID.TabIndex = 5;
            // 
            // rentalInfo_csID
            // 
            this.rentalInfo_csID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalInfo_csID.Location = new System.Drawing.Point(112, 30);
            this.rentalInfo_csID.Name = "rentalInfo_csID";
            this.rentalInfo_csID.Size = new System.Drawing.Size(178, 26);
            this.rentalInfo_csID.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Return Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Issue Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Video ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Customer ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1062, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tjGridview);
            this.Controls.Add(this.viBest);
            this.Controls.Add(this.csBest);
            this.Controls.Add(this.renRecord);
            this.Controls.Add(this.vsRecord);
            this.Controls.Add(this.csRecord);
            this.Name = "Form1";
            this.Text = "l";
            ((System.ComponentModel.ISupportInitialize)(this.tjGridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button csRecord;
        private System.Windows.Forms.Button vsRecord;
        private System.Windows.Forms.Button renRecord;
        private System.Windows.Forms.Button csBest;
        private System.Windows.Forms.Button viBest;
        private System.Windows.Forms.DataGridView tjGridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button csInfo_delete;
        private System.Windows.Forms.Button csInfo_update;
        private System.Windows.Forms.Button csInfo_Add;
        private System.Windows.Forms.TextBox csInfo_City;
        private System.Windows.Forms.TextBox csInfo_Contact;
        private System.Windows.Forms.TextBox csInfo_email;
        private System.Windows.Forms.TextBox csInfo_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viInfo_delete;
        private System.Windows.Forms.Button viInfo_update;
        private System.Windows.Forms.Button viInfo_add;
        private System.Windows.Forms.TextBox viInfo_cost;
        private System.Windows.Forms.TextBox viInfo_year;
        private System.Windows.Forms.TextBox viInfo_points;
        private System.Windows.Forms.TextBox viInfo_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete_movie_info;
        private System.Windows.Forms.Button return_movie_info;
        private System.Windows.Forms.Button issue_movie_info;
        private System.Windows.Forms.TextBox videorental_ID;
        private System.Windows.Forms.TextBox rentalInfo_csID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox viInfo_Plot;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox viInfo_Genre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox viInfo_copies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker ReturnDtp;
        private System.Windows.Forms.DateTimePicker IssueDtp;
    }
}

