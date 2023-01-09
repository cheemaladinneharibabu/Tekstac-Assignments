using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

	public class Lottery
	{

		public int LotteryNumber
		{
			set;
			get;
		}
		public string LotteryType
		{
			set;
			get;
		}
		public int Cost
		{
			set;
			get;
		}

		public float PrizeAmount
		{
			set;
			get;
		}
		public string LotteryName
		{
			set;
			get;
		}	 	  	  		    	  	   	    	 	

		public Lottery() { }
		public Lottery(int LotteryNumber, string LotteryType, int Cost, float PrizeAmount, string LotteryName)
		{
			this.LotteryNumber = LotteryNumber;
			this.LotteryType = LotteryType;
			this.Cost = Cost;
			this.PrizeAmount = PrizeAmount;
			this.LotteryName = LotteryName;
		}
	}
}