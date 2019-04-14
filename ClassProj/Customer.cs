using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Class_diagram_DONE;

namespace Class_diagram_DONE {
	public class Customer {

		public string Address { get; set; }
		public string First_name { get; set; }
		public string Last_name { get; set; }
		public int Telephone_number { get; set; }
        public string Email { get; set; }

        public Customer(string first_name, string last_name, string email)
        {
            First_name = first_name;
            Last_name = last_name;
            Email = email;
        }

	}

}