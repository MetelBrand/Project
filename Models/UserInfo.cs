using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_Project.Models
{
    public class UserInfo
    {

		public int AccountID { get; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleInit { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public int PhoneNumber { get; set; }
		public string Country { get; set; }
		public string HomeState { get; set; }
		public string City { get; set; }
		public string StreetAddress { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}

