using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public class LotteryManagement
    {
        public static List<Lottery> AvailableLottery = new List<Lottery>()
        {
            new Lottery(113,"Scratch",20,2600000,"JumboJackpot"),
            new Lottery(1002,"Ticket",40,900000,"Lotto"),
            new Lottery(1003,"Online",10,750000,"Powerball"),
            new Lottery(1004,"Scratch",100,7000000,"Poker"),
            new Lottery(1005,"Online",50,1200000,"BumperCards")
        };

        public Action<String> Query = SearchByType;

        public static List<Lottery> ResultList = new List<Lottery>();


        public static void SearchByType(String pattern)
        {

            foreach (Lottery s1 in AvailableLottery)
            {
                if (s1.LotteryType.Equals(pattern))
                {
                    Console.WriteLine("Lottery Name: "+s1.LotteryName+" Lottery Cost : "+s1.Cost+" Prize Amount : "+s1.PrizeAmount);
                    ResultList.Add(s1);
                }
            }
        }

    }
}	 	  	  		    	  	   	    	 	
