using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DapperDemo
{
	public class DataAccess
	{
		/// <summary>
		/// Connects to database and search for last names according to given text in form "lastNameText" box.
		/// </summary>
		/// <param name="lastName">Searched last name.</param>
		/// <returns></returns>
		public List<PersonModel> GetPeopleByLastName(string lastName)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
			{
				// Bad - direct SQL...
				// var output = connection.Query<PersonModel>($"select * from People where LastName = '{ lastName }';").ToList();

				// Good - using Store Procedures...
				var output = connection.Query<PersonModel>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();

				return output;
			}
		}

		public List<PersonModel> GetPeopleByFirstOrLastName(string firstName, string lastName)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
			{
				if (String.IsNullOrEmpty(firstName))
					firstName = "%";

				if (String.IsNullOrEmpty(lastName))
					lastName = "%";

				// This store procedure uses "like" in SQL query so I can use % for searching.
				var output = connection.Query<PersonModel>("dbo.People_GetByFirstOrLastName @FirstName, @LastName", new { FirstName = firstName, LastName = lastName }).ToList();

				return output;
			}
		}

		internal void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
			{
				List<PersonModel> people = new List<PersonModel>();

				people.Add(new PersonModel { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

				connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
			}
		}

		internal List<PersonModel> GetPeopleByFirstName(string firstName)
		{
			using (SqlConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
			{
				var output = connection.Query<PersonModel>("dbo.People_GetByFirstName @FirstName", new { FirstName = firstName }).ToList();

				return output;
			}
		}
	}
}
