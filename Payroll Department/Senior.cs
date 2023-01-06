using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract //DO NOT change the namespace name
{
    
    //Implement your code here
    public class Senior : Payment
    {
        public override double CalculatePayment(double basicSalary)
        {
            double da = basicSalary * 0.15;
            double hra = basicSalary * 0.10;
            double conveyance = basicSalary * 0.07;
            double medical = basicSalary * 0.05;
            double flexible = basicSalary * 0.30;

            return basicSalary + da + hra + conveyance + medical + flexible;
        }
    }
}