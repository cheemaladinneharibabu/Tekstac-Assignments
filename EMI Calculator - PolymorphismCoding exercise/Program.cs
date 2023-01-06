	Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmiCalculator //DO NOT Change namespace name
{
    public class Program      //DO NOT Change class 'Program' name
    {
        
        public static void Main(string[] args)
        {
            
           Program pobj= new Program();
           Loan lobj = new Loan();
           Console.Write("Loan Number : ");
           lobj.LoanNumber = Console.ReadLine();
           Console.Write("Loan Provider Name : ");
           lobj.LoanProviderName = Console.ReadLine();
           Console.Write("Loan Amount : ");
           lobj.LoanAmount = Convert.ToDouble(Console.ReadLine());
           Console.Write("Select\n1.Personal Loan \n2.Home Loan : ");
           int opt = Convert.ToInt32(Console.ReadLine());
           double emi = pobj.addLoan(lobj,opt);
           Console.WriteLine("Calculated EMI : "+emi);
        }
       //Implement required methods here
       public double addLoan(Loan lobj,int opt)
       {
           double emi;
           if(opt == 1)
           {
               PersonalLoan pobj = new PersonalLoan();
               pobj.LoanNumber = lobj.LoanNumber;
               pobj.LoanProviderName = lobj.LoanProviderName;
               pobj.LoanAmount = lobj.LoanAmount;
               Console.Write("Number of Years : ");
                pobj.NumberOfYears = Convert.ToInt32(Console.ReadLine());
               Console.Write("Interest Rate : ");
               pobj.InterestRate = float.Parse(Console.ReadLine());
               emi = pobj.calculateEMI();
           }	 	  	  		    	  	   	    	 	
           else
           {
               HomeLoan hobj = new HomeLoan();
               hobj.LoanNumber = lobj.LoanNumber;
               hobj.LoanProviderName = lobj.LoanProviderName;
               hobj.LoanAmount = lobj.LoanAmount;
               Console.Write("House Age : ");
               hobj.HouseAge = Convert.ToInt32(Console.ReadLine());
               Console.Write("Interest Rate : ");
               hobj.InterestRate = float.Parse(Console.ReadLine());
              
               emi = hobj.calculateEMI();
           }
           return emi;
       }
    }
}
