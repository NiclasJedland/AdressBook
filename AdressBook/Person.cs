using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
	public class Person
	{
		public int PersonId { get; set; }
		public string Name { get; set; }
		public string Adress { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		[Column(TypeName = "date")]
		public DateTime Birthday { get; set; }

		public Person() { }

		public Person(string name, string adress, string zipCode, string city, string phoneNumber, string email, DateTime birthday)
		{
			Name = name;
			Adress = adress;
			ZipCode = zipCode;
			City = city;
			PhoneNumber = phoneNumber;
			Email = email;
			Birthday = birthday;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
