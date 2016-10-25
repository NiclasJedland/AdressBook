namespace AdressBook
{
	partial class frmAddContact
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
			this.lblWarning = new System.Windows.Forms.Label();
			this.grpInformation = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelephoneNumber = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.lblZipcode = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.grpInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(24, -5);
			this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 17);
			this.lblWarning.TabIndex = 9;
			// 
			// grpInformation
			// 
			this.grpInformation.Controls.Add(this.btnCancel);
			this.grpInformation.Controls.Add(this.txtName);
			this.grpInformation.Controls.Add(this.lblBirthday);
			this.grpInformation.Controls.Add(this.dtpBirthday);
			this.grpInformation.Controls.Add(this.btnSave);
			this.grpInformation.Controls.Add(this.txtEmail);
			this.grpInformation.Controls.Add(this.lblEmail);
			this.grpInformation.Controls.Add(this.lblTelephoneNumber);
			this.grpInformation.Controls.Add(this.txtPhoneNumber);
			this.grpInformation.Controls.Add(this.txtCity);
			this.grpInformation.Controls.Add(this.lblCity);
			this.grpInformation.Controls.Add(this.txtZipCode);
			this.grpInformation.Controls.Add(this.lblZipcode);
			this.grpInformation.Controls.Add(this.txtAddress);
			this.grpInformation.Controls.Add(this.lblAddress);
			this.grpInformation.Controls.Add(this.lblName);
			this.grpInformation.Location = new System.Drawing.Point(16, 15);
			this.grpInformation.Margin = new System.Windows.Forms.Padding(4);
			this.grpInformation.Name = "grpInformation";
			this.grpInformation.Padding = new System.Windows.Forms.Padding(4);
			this.grpInformation.Size = new System.Drawing.Size(437, 317);
			this.grpInformation.TabIndex = 8;
			this.grpInformation.TabStop = false;
			this.grpInformation.Text = "Information";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(146, 255);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(133, 42);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(147, 23);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(280, 22);
			this.txtName.TabIndex = 1;
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
			this.dtpBirthday.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(294, 255);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 42);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(147, 181);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(280, 22);
			this.txtEmail.TabIndex = 7;
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
			this.txtPhoneNumber.TabIndex = 6;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(147, 117);
			this.txtCity.Margin = new System.Windows.Forms.Padding(4);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(280, 22);
			this.txtCity.TabIndex = 5;
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
			this.txtZipCode.TabIndex = 4;
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
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(147, 53);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(280, 22);
			this.txtAddress.TabIndex = 3;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(8, 57);
			this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(64, 17);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address:";
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
			// frmAddContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 343);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpInformation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmAddContact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Contact";
			this.grpInformation.ResumeLayout(false);
			this.grpInformation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.GroupBox grpInformation;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTelephoneNumber;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label lblZipcode;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblName;
	}
}