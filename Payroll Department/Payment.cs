using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract //DO NOT change the namespace name
{
    
    //Implement your code here
    public abstract class Payment
    {
        public abstract double CalculatePayment(double basicSalary);
    }
}