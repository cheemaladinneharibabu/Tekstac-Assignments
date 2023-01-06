using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Payment payment = null;

            while(true)
            {
                Console.WriteLine("1. Calculate salary for junior");
                Console.WriteLine("2. Calculate salary for senior");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            payment = new Junior();

                            Console.WriteLine("Enter the basic salary");
                            double basicSal = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(payment.CalculatePayment(basicSal));
                            break;
                        }
                    case 2:
                        {
                            payment = new Senior();

                            Console.WriteLine("Enter the basic salary");
                            double basicSal = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(payment.CalculatePayment(basicSal));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Thank u");
                            break;
                        }
                }
            }

            Console.ReadLine();
        }
    }
}
