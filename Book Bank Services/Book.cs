using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesProject
{
	public class Book
	{
		public string BookCode
		{
			set;
			get;
		}
		public string BookName
		{
			set;
			get;
		}

		public string AuthorName
		{
			set;
			get;
		}
		public int AvailableBook
		{
			set;
			get;
		}

		public float BooKCost
		{
			set;
			get;
		}


		public Book() { }	 	  	  		    	  	   	    	 	
		public Book(string BookCode, string BookName, string AuthorName, int AvailableBook, float BooKCost)
		{
			this.BookCode = BookCode;
			this.BookName = BookName;
			this.AuthorName = AuthorName;
			this.AvailableBook = AvailableBook;
			this.BooKCost = BooKCost;
		}
	}
}
