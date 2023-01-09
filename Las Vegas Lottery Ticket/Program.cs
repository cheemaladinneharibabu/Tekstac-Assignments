using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents          //DO NOT change the namespace name
{
	public class Program //DO NOT change the class name
	{
		static void Main(string[] args)
		{
			LotteryManagement cm = new LotteryManagement();
			cm.Query("Online");
		}
	}
}
