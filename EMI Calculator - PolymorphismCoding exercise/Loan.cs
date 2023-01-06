	Loan.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmiCalculator             //DO NOT Change namespace name
{
    //Implement the code here. Keep the class 'public'
    public class Loan
    {
        private string loanNumber;
        private string loanProviderName;
        private double loanAmount;
        public string LoanNumber
        {
            get{return loanNumber;}
            set{
                loanNumber=value;
            }
        }
        public string LoanProviderName
        {
            get{return loanProviderName;}
            set{
                loanProviderName=value;
            }
        }
        public double LoanAmount
        {
            get{return loanAmount;}
            set{
                loanAmount=value;
            }
        }
    }
    public class PersonalLoan : Loan
    {	 	  	  		    	  	   	    	 	
        private int numberOfYears;
        private float interestRate;
        public int NumberOfYears{
            get{return numberOfYears;}
            set{
                numberOfYears=value;
            }
        }
        public float InterestRate{
            get{return interestRate;}
            set{
                interestRate=value;
            }
        }
        public double calculateEMI()
        {
           
            double emi =(LoanAmount+ (LoanAmount*NumberOfYears*InterestRate*0.01))/(NumberOfYears*12);
           
          
            return emi;
        }
    }
    public class HomeLoan : Loan
    {
        private int houseAge;
        private float interestRate;
        public int HouseAge{
            get{return houseAge;}
            set{
                houseAge = value;
            }
        }
        public float InterestRate{
            get{return interestRate;}
            set{	 	  	  		    	  	   	    	 	
                interestRate = value;
            }
        }
        public double calculateEMI()
        {
           double emi =(LoanAmount+(LoanAmount*InterestRate*0.01))/(HouseAge*12);
            //double emi = result/(HouseAge*12) ; 
          
            return emi;
        }
    }
}


