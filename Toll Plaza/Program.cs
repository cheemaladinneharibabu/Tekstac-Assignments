using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollPlaza //DO NOT change the namespace name
{
	public class Program //DO NOT change the class name
	{
		public static void Main(string[] args) //DO NOT change the 'Main' method signature
		{
		    //Implement your code here
		    LMV lmvobj = new LMV();
            HMV hmvobj = new HMV();
            LCV lcvobj = new LCV();
            HCV hcvobj = new HCV();

            Console.WriteLine("Enter the vehicle type");
            String vehicleType = Console.ReadLine();

            if(vehicleType == "LMV")
            {
                Console.WriteLine(lmvobj.CalculateTollCharge());
            }
            else if (vehicleType == "HMV")
            {
                Console.WriteLine(hmvobj.CalculateTollCharge());
            }
            else if (vehicleType == "LCV")
            {
                Console.WriteLine(lcvobj.CalculateTollCharge());
            }
            else if (vehicleType == "HCV")
            {
                Console.WriteLine(hcvobj.CalculateTollCharge());
            }	 	  	  		    	  	   	    	 	
            else
            {
                Console.WriteLine("Invalid vehicle type");
            }
		}
	}
}
