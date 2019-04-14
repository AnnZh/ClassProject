using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Class_diagram_DONE;


namespace Class_diagram_DONE {
	public class Order : Customer{

        public Order(string first_name, string last_name, string email): base(first_name, last_name, email)
        {

        }
              

        public void GetEmail()
        {
            Email = Console.ReadLine();
        }

		public bool VerifyEmail(){

            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            if (Regex.IsMatch(Email, cond))
            {
                Console.WriteLine("Email is correct!\n");
                return true;               
            }
            else
            {
                Console.WriteLine("Email is incorrect!\n");
                return false;
            }
		}

	}

}