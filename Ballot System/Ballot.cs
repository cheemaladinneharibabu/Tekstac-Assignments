using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallotSystem //Do not change the namespace name
{
	//Implement the code here
	public class Ballot
    {
        public SortedDictionary<String, long> BallotDetails
        {
            set;
            get;
        }

        public Ballot()
        {
            BallotDetails = new SortedDictionary<string, long>();
        }
        public SortedDictionary<String, long> AddBallotDetails(String brandName, long soldUnits)
        {
            BallotDetails.Add(brandName, soldUnits);

            return BallotDetails;
        }
        public SortedDictionary<String, long> CountMaxVotersCount(SortedDictionary<String, long> ballotDetails)
        {
            SortedDictionary<String, long> result = new SortedDictionary<string, long>();

            var maxValue = ballotDetails.Values.Max();

            var list = ballotDetails.Where(w => maxValue.Equals(w.Value)).ToList();

            foreach (KeyValuePair<String, long> kv in list)
            {	 	  	  		    	  	   	    	 	
                result.Add(kv.Key, kv.Value);
            }
           
            return result;
        }
        public SortedDictionary<String, long> ViewWardAboveRange(long votersCount)
        {

            SortedDictionary<String, long> result = new SortedDictionary<string, long>();

            var list = BallotDetails.Where(w => w.Value > votersCount).ToList();

            foreach (KeyValuePair<String, long> kv in list)
            {
                result.Add(kv.Key, kv.Value);
            }
            
            return result;
        }
    }
}
