namespace AdressBook
{
	partial class Adressbook
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
			if(disposing && (components != null))
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.grpInformation = new System.Windows.Forms.GroupBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAddContact = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelephoneNumber = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.lblZipcode = new System.Windows.Forms.Label();
			this.txtAdress = new System.Windows.Forms.TextBox();
			this.lblAdress = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.grpPeople = new System.Windows.Forms.GroupBox();
			this.lstPeople = new System.Windows.Forms.ListBox();
			this.lblWarning = new System.Windows.Forms.Label();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.grpInformation.SuspendLayout();
			this.grpPeople.SuspendLayout();
			this.gbSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(7, 26);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(249, 22);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// grpInformation
			// 
			this.grpInformation.Controls.Add(this.txtName);
			this.grpInformation.Controls.Add(this.lblBirthday);
			this.grpInformation.Controls.Add(this.dtpBirthday);
			this.grpInformation.Controls.Add(this.btnRemove);
			this.grpInformation.Controls.Add(this.btnAddContact);
			this.grpInformation.Controls.Add(this.btnSaveChanges);
			this.grpInformation.Controls.Add(this.txtEmail);
			this.grpInformation.Controls.Add(this.lblEmail);
			this.grpInformation.Controls.Add(this.lblTelephoneNumber);
			this.grpInformation.Controls.Add(this.txtPhoneNumber);
			this.grpInformation.Controls.Add(this.txtCity);
			this.grpInformation.Controls.Add(this.lblCity);
			this.grpInformation.Controls.Add(this.txtZipCode);
			this.grpInformation.Controls.Add(this.lblZipcode);
			this.grpInformation.Controls.Add(this.txtAdress);
			this.grpInformation.Controls.Add(this.lblAdress);
			this.grpInformation.Controls.Add(this.lblName);
			this.grpInformation.Location = new System.Drawing.Point(291, 26);
			this.grpInformation.Margin = new System.Windows.Forms.Padding(4);
			this.grpInformation.Name = "grpInformation";
			this.grpInformation.Padding = new System.Windows.Forms.Padding(4);
			this.grpInformation.Size = new System.Drawing.Size(437, 326);
			this.grpInformation.TabIndex = 5;
			this.grpInformation.TabStop = false;
			this.grpInformation.Text = "Information";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(147, 23);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(280, 22);
			this.txtName.TabIndex = 2;
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(8, 221);
			this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(64, 17);
			this.lblBirthday.TabIndex = 18;
			this.lblBirthday.Text = "Birthday:";
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(147, 213);
			this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(280, 22);
			this.dtpBirthday.TabIndex = 9;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(6, 260);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(133, 42);
			this.btnRemove.TabIndex = 12;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAddContact
			// 
			this.btnAddContact.Location = new System.Drawing.Point(151, 260);
			this.btnAddContact.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddContact.Name = "btnAddContact";
			this.btnAddContact.Size = new System.Drawing.Size(133, 42);
			this.btnAddContact.TabIndex = 11;
			this.btnAddContact.Text = "Add A New Contact";
			this.btnAddContact.UseVisualStyleBackColor = true;
			this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(294, 260);
			this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(133, 42);
			this.btnSaveChanges.TabIndex = 10;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(147, 181);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(280, 22);
			this.txtEmail.TabIndex = 8;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(8, 185);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(46, 17);
			this.lblEmail.TabIndex = 12;
			this.lblEmail.Text = "Email:";
			// 
			// lblTelephoneNumber
			// 
			this.lblTelephoneNumber.AutoSize = true;
			this.lblTelephoneNumber.Location = new System.Drawing.Point(8, 153);
			this.lblTelephoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelephoneNumber.Name = "lblTelephoneNumber";
			this.lblTelephoneNumber.Size = new System.Drawing.Size(134, 17);
			this.lblTelephoneNumber.TabIndex = 11;
			this.lblTelephoneNumber.Text = "Telephone Number:";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(147, 149);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(280, 22);
			this.txtPhoneNumber.TabIndex = 7;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(147, 117);
			this.txtCity.Margin = new System.Windows.Forms.Padding(4);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(280, 22);
			this.txtCity.TabIndex = 6;
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(8, 121);
			this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(35, 17);
			this.lblCity.TabIndex = 8;
			this.lblCity.Text = "City:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(147, 85);
			this.txtZipCode.Margin = new System.Windows.Forms.Padding(4);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(280, 22);
			this.txtZipCode.TabIndex = 5;
			// 
			// lblZipcode
			// 
			this.lblZipcode.AutoSize = true;
			this.lblZipcode.Location = new System.Drawing.Point(8, 89);
			this.lblZipcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblZipcode.Name = "lblZipcode";
			this.lblZipcode.Size = new System.Drawing.Size(67, 17);
			this.lblZipcode.TabIndex = 6;
			this.lblZipcode.Text = "Zip code:";
			// 
			// txtAdress
			// 
			this.txtAdress.Location = new System.Drawing.Point(147, 53);
			this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAdress.Name = "txtAdress";
			this.txtAdress.Size = new System.Drawing.Size(280, 22);
			this.txtAdress.TabIndex = 4;
			// 
			// lblAdress
			// 
			this.lblAdress.AutoSize = true;
			this.lblAdress.Location = new System.Drawing.Point(8, 57);
			this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAdress.Name = "lblAdress";
			this.lblAdress.Size = new System.Drawing.Size(56, 17);
			this.lblAdress.TabIndex = 4;
			this.lblAdress.Text = "Adress:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(8, 27);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(49, 17);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// grpPeople
			// 
			this.grpPeople.Controls.Add(this.lstPeople);
			this.grpPeople.Location = new System.Drawing.Point(11, 14);
			this.grpPeople.Margin = new System.Windows.Forms.Padding(4);
			this.grpPeople.Name = "grpPeople";
			this.grpPeople.Padding = new System.Windows.Forms.Padding(4);
			this.grpPeople.Size = new System.Drawing.Size(267, 295);
			this.grpPeople.TabIndex = 4;
			this.grpPeople.TabStop = false;
			this.grpPeople.Text = "People";
			// 
			// lstPeople
			// 
			this.lstPeople.FormattingEnabled = true;
			this.lstPeople.ItemHeight = 16;
			this.lstPeople.Location = new System.Drawing.Point(8, 23);
			this.lstPeople.Margin = new System.Windows.Forms.Padding(4);
			this.lstPeople.Name = "lstPeople";
			this.lstPeople.Size = new System.Drawing.Size(249, 260);
			this.lstPeople.TabIndex = 0;
			this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(433, 6);
			this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 17);
			this.lblWarning.TabIndex = 22;
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.txtSearch);
			this.gbSearch.Location = new System.Drawing.Point(12, 304);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(266, 68);
			this.gbSearch.TabIndex = 23;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Search";
			// 
			// Adressbook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 389);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpInformation);
			this.Controls.Add(this.grpPeople);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Adressbook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contacts";
			this.Load += new System.EventHandler(this.Adressbook_Load);
			this.grpInformation.ResumeLayout(false);
			this.grpInformation.PerformLayout();
			this.grpPeople.ResumeLayout(false);
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.GroupBox grpInformation;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAddContact;
		private System.Windows.Forms.Button btnSaveChanges;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTelephoneNumber;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label lblZipcode;
		private System.Windows.Forms.TextBox txtAdress;
		private System.Windows.Forms.Label lblAdress;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.GroupBox grpPeople;
		private System.Windows.Forms.ListBox lstPeople;
		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.GroupBox gbSearch;
	}
}

