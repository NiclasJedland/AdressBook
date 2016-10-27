using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdressBook
{
	public partial class Adressbook : Form
	{
		public Adressbook()
		{
			InitializeComponent();
		}

		#region Events
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				var test = lstPeople.SelectedItem;
				if(MessageBox.Show("Remove Selected", "Remove " + lstPeople.SelectedItem + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Timer timer = new Timer();
					timer.Interval = 3000;
					timer.Enabled = true;
					timer.Tick += new EventHandler(FadeWarningText);

					var toBeRemoved = lstPeople.SelectedItem;

					using(var db = new PersonContext())
					{
						db.Entry(toBeRemoved).State = EntityState.Deleted;

						db.SaveChanges();
					}

					lblWarning.ForeColor = Color.Red;
					lblWarning.Text = toBeRemoved + " Removed!";

					UpdateList();
				}
				txtSearch.Text = "";
			}
		}

		private void btnAddContact_Click(object sender, EventArgs e)
		{
			this.Hide();
			var newWindow = new frmAddContact();
			newWindow.Closed += (s, args) => this.Show();
			newWindow.SavedDatabase += OnSavedDatabase;
			newWindow.Show();
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Update " + lstPeople.SelectedItem, "Save changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using(var db = new PersonContext())
					{
						Timer timer = new Timer();
						timer.Interval = 3000;
						timer.Enabled = true;
						timer.Tick += new EventHandler(FadeWarningText);

						var toBeUpdated = (Person)lstPeople.SelectedItem;

						toBeUpdated.Name = txtName.Text;
						toBeUpdated.Adress = txtAdress.Text;
						toBeUpdated.ZipCode = txtZipCode.Text;
						toBeUpdated.City = txtCity.Text;
						toBeUpdated.PhoneNumber = txtPhoneNumber.Text;
						toBeUpdated.Email = txtEmail.Text;
						toBeUpdated.Birthday = dtpBirthday.Value;

						db.Entry(toBeUpdated).State = EntityState.Modified;

						db.SaveChanges();

						lblWarning.ForeColor = Color.Green;
						lblWarning.Text = toBeUpdated.Name + " Updated!";
					}

					UpdateList();
				}
				txtSearch.Text = "";
			}
		}

		private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				var selectedItem = (Person)lstPeople.SelectedItem;

				txtName.Text = selectedItem.Name;
				txtAdress.Text = selectedItem.Adress;
				txtZipCode.Text = selectedItem.ZipCode;
				txtCity.Text = selectedItem.City;
				txtPhoneNumber.Text = selectedItem.PhoneNumber;
				txtEmail.Text = selectedItem.Email;
				dtpBirthday.Value = selectedItem.Birthday;
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void Adressbook_Load(object sender, EventArgs e)
		{
			UpdateList();
		}
		#endregion

		#region Methods
		private void UpdateList()
		{
			lstPeople.Items.Clear();

			txtName.Text = "";
			txtAdress.Text = "";
			txtZipCode.Text = "";
			txtCity.Text = "";
			txtPhoneNumber.Text = "";
			txtEmail.Text = "";
			dtpBirthday.Value = DateTime.Today;

			using(var db = new PersonContext())
			{
				var people = db.People.OrderBy(s => s.Name);

				if(txtSearch.Text.Length > 0)
				{
					var searchText = txtSearch.Text.Trim().ToLower();
					people = db.People.Where(s =>
						s.Name.ToLower().Contains(searchText)
						|| s.Adress.ToLower().Contains(searchText)
						|| s.City.ToLower().Contains(searchText) 
						|| s.ZipCode.ToLower().Contains(searchText)
						|| s.PhoneNumber.ToLower().Contains(searchText)
						|| s.Email.ToLower().Contains(searchText)
						|| s.Birthday.ToString().ToLower().Contains(searchText)
						).OrderBy(s => s.Name);
				}

				foreach(var item in people)
				{
					lstPeople.Items.Add(item);
				}
			}
		}

		private void FadeWarningText(object sender, EventArgs e)
		{
			lblWarning.Text = "";
		}

		public void OnSavedDatabase(object source, EventArgs e)
		{
			UpdateList();
		}
		#endregion

		#region Keypress
		private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
			{
				e.Handled = true;
			}
		}
		#endregion
	}
}