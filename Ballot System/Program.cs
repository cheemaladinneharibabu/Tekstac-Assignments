using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallotSystem //Do not change the namespace name
{
	//Implement the code here
	public class Program
    {
        static void Main(string[] args)
        {
            Ballot ballotobj = new Ballot();

            Console.WriteLine("1.Add ballot details");
            Console.WriteLine("2.Get ward count with max voters count");
            Console.WriteLine("3.View ward names above range");
            Console.WriteLine("4.Exit");

            while (true)
            {
                Console.WriteLine("Enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter ward name and voters count");
                            String wardName = Console.ReadLine();
                            long votersCount = long.Parse(Console.ReadLine());

                            SortedDictionary<String, long> result = new SortedDictionary<string, long>();

                            result = ballotobj.AddBallotDetails(wardName, votersCount);

                            break;
                        }	 	  	  		    	  	   	    	 	
                    case 2:
                        {
                            SortedDictionary<String, long> result = new SortedDictionary<string, long>();

                            result = ballotobj.CountMaxVotersCount(ballotobj.BallotDetails);

                            foreach (KeyValuePair<String, long> kv in result)
                            {
                                Console.WriteLine(kv.Key + "    " + kv.Value);
                            }
                            //Console.WriteLine(resultCount);

                            break;
                        }
                    case 3:
                        {
                            SortedDictionary<String, long> result = new SortedDictionary<string, long>();

                            Console.WriteLine("Enter the voters count");
                            long voterCount = long.Parse(Console.ReadLine());

                            result = ballotobj.ViewWardAboveRange(voterCount);

                            foreach (KeyValuePair<String, long> kv in result)
                            {
                                Console.WriteLine(kv.Key + "    " + kv.Value);
                            }

                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                }
            }	 	  	  		    	  	   	    	 	
        }
    }
}
