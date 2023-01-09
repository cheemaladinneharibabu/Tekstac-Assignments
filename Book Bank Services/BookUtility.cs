using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesProject
{
    public class BookUtility
    {
        public static List<Book> BookList = new List<Book>()
        {
            new Book("ISIN4567","Java","Balagurusamy",60,400),
            new Book("ISIN7777","DotNet","James",79,700),
            new Book("ISIN4888","HTML","Louis",30,460),
            new Book("ISIN7999","TomSawyer","Mark",20,600),
            new Book("ISIN6666","Alice Adventures","Lewis",40,800)
        };

        public Predicate<String> QueryToSearch = FindBookAvailability;

        public static bool FindBookAvailability(String bookCode)
        {

            bool result = false;
            foreach (Book s1 in BookList)
            {

                if (s1.BookCode.Equals(bookCode))
                {
                    Console.WriteLine("Book Name : " + s1.BookName);
                    Console.WriteLine("Available Book : " + s1.AvailableBook);


                    result = true;
                }
            }

            return result;
        }	 	  	  		    	  	   	    	 	

    }
}
