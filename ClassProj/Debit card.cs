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

            Console.WriteLine("���� �������� ����� - {0}", CardDate);
            Console.WriteLine("����� ����� - {0}", NumberOfCard);
            Console.WriteLine("��� ��������� - {0}", customer.First_name +" "+ customer.Last_name);
            Console.WriteLine("Email ��������� - {0}", customer.Email);
        }

		

	}

}