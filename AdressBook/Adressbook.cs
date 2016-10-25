using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook
{
	public partial class Adressbook : Form
	{
		public List<Person> peopleList = new List<Person>();

		public Adressbook()
		{
			InitializeComponent();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Remove " + lstPeople.SelectedItem + "?", "Remove Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Timer timer = new Timer();
					timer.Interval = 3000;
					timer.Enabled = true;
					timer.Tick += new EventHandler(FadeWarningText);

					var toBeRemoved = peopleList[lstPeople.SelectedIndex];

					using(var db = new PersonContext())
					{
						db.Entry(toBeRemoved).State = EntityState.Deleted;

						db.SaveChanges();
					}

					lblWarning.ForeColor = Color.Red;
					lblWarning.Text = toBeRemoved.Name + " Removed!";

					UpdateList(true);
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
				if(MessageBox.Show("Save changes?", "Update Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using(var db = new PersonContext())
					{
						Timer timer = new Timer();
						timer.Interval = 3000;
						timer.Enabled = true;
						timer.Tick += new EventHandler(FadeWarningText);

						var toBeUpdated = peopleList[lstPeople.SelectedIndex];

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

					UpdateList(true);
				}
				txtSearch.Text = "";
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(txtSearch.Text))
			{
				Search(txtSearch.Text);
				UpdateList(false);
			}
			else
				UpdateList(true);
		}

		private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(lstPeople.SelectedItem != null)
				{
					txtName.Text = peopleList[lstPeople.SelectedIndex].Name;
					txtAdress.Text = peopleList[lstPeople.SelectedIndex].Adress;
					txtZipCode.Text = peopleList[lstPeople.SelectedIndex].ZipCode;
					txtCity.Text = peopleList[lstPeople.SelectedIndex].City;
					txtPhoneNumber.Text = peopleList[lstPeople.SelectedIndex].PhoneNumber;
					txtEmail.Text = peopleList[lstPeople.SelectedIndex].Email;
					dtpBirthday.Value = peopleList[lstPeople.SelectedIndex].Birthday;
				}
			}
		}

		private void Adressbook_Load(object sender, EventArgs e)
		{
			UpdateList(true);
		}

		void UpdateList(bool loadDatabase)
		{
			lstPeople.Items.Clear();

			txtName.Text = "";
			txtAdress.Text = "";
			txtZipCode.Text = "";
			txtCity.Text = "";
			txtPhoneNumber.Text = "";
			txtEmail.Text = "";
			dtpBirthday.Value = DateTime.Today;

			if(loadDatabase)
			{
				peopleList.Clear();
				using(var db = new PersonContext())
				{
					var people = db.Persons.Select(s => s);

					foreach(var item in people)
					{
						peopleList.Add(item);
					}
				}
			}

			peopleList = peopleList.OrderBy(x => x.Name).ToList();

			foreach(var person in peopleList)
			{
				lstPeople.Items.Add(person.Name);
			}
		}

		public void OnSavedDatabase(object source, EventArgs e)
		{
			UpdateList(true);
		}
		private void FadeWarningText(object sender, EventArgs e)
		{
			lblWarning.Text = "";
		}
		public void Search(string searchString)
		{
			peopleList = peopleList.Where(p =>
				p.Name.ToLower().Contains(searchString.ToLower()) ||
				p.Adress.ToLower().Contains(searchString.ToLower()) ||
				p.City.ToLower().Contains(searchString.ToLower()) ||
				p.Email.ToLower().Contains(searchString.ToLower())
				).ToList();
		}
	}
}
