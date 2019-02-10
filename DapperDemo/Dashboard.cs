using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
	public partial class Dashboard : Form
	{
		List<PersonModel> people = new List<PersonModel>();

		public Dashboard()
		{
			InitializeComponent();

			UpdateBinding();
		}

		private void UpdateBinding()
		{
			peopleFoundListBox.DataSource = people;
			peopleFoundListBox.DisplayMember = "FullInfo";
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();

			// List "people" is populated with result of database query.
			people = db.GetPeopleByLastName(lastNameText.Text);

			UpdateBinding();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();

			db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);

			firstNameInsText.Text = "";
			lastNameInsText.Text = "";
			emailAddressInsText.Text = "";
			phoneNumberInsText.Text = "";

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();

			people = db.GetPeopleByFirstOrLastName(firstNameText.Text, lastNameText.Text);

			UpdateBinding();
		}

		private void searchByFirstNameButton_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();

			people = db.GetPeopleByFirstName(firstNameText.Text);

			UpdateBinding();
		}
	}
}
