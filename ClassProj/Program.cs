using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_diagram_DONE;

namespace ClassProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("Ann", "Zhurok", "annzhurok@mail.ru");
            order.GetEmail();
            order.VerifyEmail();
            Debit_card debit = new Debit_card(order, 2018, 1412341234);
            debit.GetCardInfo();
            Console.ReadKey();
        }
    }
}
