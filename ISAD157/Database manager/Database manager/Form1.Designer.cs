namespace Database_manager
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
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.dataGridFriendship = new System.Windows.Forms.DataGridView();
            this.ComboBoxDB = new System.Windows.Forms.ComboBox();
            this.dataGridFriendList = new System.Windows.Forms.DataGridView();
            this.dataGridMessages = new System.Windows.Forms.DataGridView();
            this.dataGridUniversities = new System.Windows.Forms.DataGridView();
            this.dataGridWorkplace = new System.Windows.Forms.DataGridView();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textHometown = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DATABASE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriendship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriendList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUniversities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(21, 180);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(332, 185);
            this.dataGridUser.TabIndex = 0;
            this.dataGridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellClick);
            // 
            // dataGridFriendship
            // 
            this.dataGridFriendship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFriendship.Location = new System.Drawing.Point(381, 180);
            this.dataGridFriendship.Name = "dataGridFriendship";
            this.dataGridFriendship.Size = new System.Drawing.Size(332, 185);
            this.dataGridFriendship.TabIndex = 1;
            // 
            // ComboBoxDB
            // 
            this.ComboBoxDB.FormattingEnabled = true;
            this.ComboBoxDB.Items.AddRange(new object[] {
            "Facebook Users Table",
            "Friendship Table",
            "FriendList Table",
            "Messages Table",
            "Universities Table",
            "Workplace Table"});
            this.ComboBoxDB.Location = new System.Drawing.Point(21, 135);
            this.ComboBoxDB.Name = "ComboBoxDB";
            this.ComboBoxDB.Size = new System.Drawing.Size(332, 21);
            this.ComboBoxDB.TabIndex = 2;
            this.ComboBoxDB.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDB_SelectedIndexChanged);
            // 
            // dataGridFriendList
            // 
            this.dataGridFriendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFriendList.Location = new System.Drawing.Point(381, 371);
            this.dataGridFriendList.Name = "dataGridFriendList";
            this.dataGridFriendList.Size = new System.Drawing.Size(332, 185);
            this.dataGridFriendList.TabIndex = 3;
            // 
            // dataGridMessages
            // 
            this.dataGridMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessages.Location = new System.Drawing.Point(21, 371);
            this.dataGridMessages.Name = "dataGridMessages";
            this.dataGridMessages.Size = new System.Drawing.Size(332, 185);
            this.dataGridMessages.TabIndex = 4;
            // 
            // dataGridUniversities
            // 
            this.dataGridUniversities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUniversities.Location = new System.Drawing.Point(21, 562);
            this.dataGridUniversities.Name = "dataGridUniversities";
            this.dataGridUniversities.Size = new System.Drawing.Size(332, 185);
            this.dataGridUniversities.TabIndex = 5;
            // 
            // dataGridWorkplace
            // 
            this.dataGridWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkplace.Location = new System.Drawing.Point(381, 562);
            this.dataGridWorkplace.Name = "dataGridWorkplace";
            this.dataGridWorkplace.Size = new System.Drawing.Size(332, 185);
            this.dataGridWorkplace.TabIndex = 6;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(855, 184);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(231, 20);
            this.textFirstName.TabIndex = 7;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(855, 223);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(231, 20);
            this.textLastName.TabIndex = 8;
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(855, 260);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(231, 20);
            this.textGender.TabIndex = 9;
            // 
            // textHometown
            // 
            this.textHometown.Location = new System.Drawing.Point(855, 297);
            this.textHometown.Name = "textHometown";
            this.textHometown.Size = new System.Drawing.Size(231, 20);
            this.textHometown.TabIndex = 10;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(855, 332);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(231, 20);
            this.textCity.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(750, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(959, 371);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(127, 37);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(855, 149);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(231, 20);
            this.textUserID.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnExit.Location = new System.Drawing.Point(945, 708);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserID.Location = new System.Drawing.Point(746, 149);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(60, 20);
            this.UserID.TabIndex = 16;
            this.UserID.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(746, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(746, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(746, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(746, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hometown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(746, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "City";
            // 
            // DATABASE
            // 
            this.DATABASE.AutoSize = true;
            this.DATABASE.Font = new System.Drawing.Font("Monotype Corsiva", 70F);
            this.DATABASE.Location = new System.Drawing.Point(199, -1);
            this.DATABASE.Name = "DATABASE";
            this.DATABASE.Size = new System.Drawing.Size(681, 113);
            this.DATABASE.TabIndex = 22;
            this.DATABASE.Text = "Database Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1106, 787);
            this.Controls.Add(this.DATABASE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textHometown);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.dataGridWorkplace);
            this.Controls.Add(this.dataGridUniversities);
            this.Controls.Add(this.dataGridMessages);
            this.Controls.Add(this.dataGridFriendList);
            this.Controls.Add(this.ComboBoxDB);
            this.Controls.Add(this.dataGridFriendship);
            this.Controls.Add(this.dataGridUser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriendship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriendList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUniversities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.DataGridView dataGridFriendship;
        private System.Windows.Forms.ComboBox ComboBoxDB;
        private System.Windows.Forms.DataGridView dataGridFriendList;
        private System.Windows.Forms.DataGridView dataGridMessages;
        private System.Windows.Forms.DataGridView dataGridUniversities;
        private System.Windows.Forms.DataGridView dataGridWorkplace;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textHometown;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DATABASE;
    }
}

