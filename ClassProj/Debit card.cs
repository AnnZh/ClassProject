using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Class_diagram_DONE {
	public class Debit_card {

		protected int CardDate;
		protected int NumberOfCard;
        protected Customer customer;

		public Debit_card(Customer cust, int cardDate, int numberOfCard){
            CardDate = cardDate;
            NumberOfCard = numberOfCard;
            customer = cust;
        }

		public void GetCardInfo(){

            Console.WriteLine("Дата закрытия карты - {0}", CardDate);
            Console.WriteLine("Номер карты - {0}", NumberOfCard);
            Console.WriteLine("Имя владельца - {0}", customer.First_name +" "+ customer.Last_name);
            Console.WriteLine("Email владельца - {0}", customer.Email);
        }

		

	}

}