using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject          //DO NOT change the namespace name
{
	public class Program //DO NOT change the class name
	{
		static void Main(string[] args)
		{
			BookUtility du = new BookUtility();
			
			bool check = du.QueryToSearch("ISIN6666");

			Console.WriteLine(check);
		}
	}
}
