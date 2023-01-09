using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ListClass //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static List<Case> CaseFile = new List<Case>();
        
        //Implement the methods here
        
        public bool AddToList(Case caseObj)
        {
            CaseFile.Add(caseObj);

            for (int i = 0; i < CaseFile.Count; i++)
            {
                if (CaseFile[i].CaseCode == caseObj.CaseCode)
                {
                    return true;
                }
            }
            return false;    
        }
        
        public bool DeleteFromList(int caseNo)
        {
            for (int i = 0; i < CaseFile.Count; i++)
            {
                if (CaseFile[i].CaseNo == caseNo)
                {
                    CaseFile.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Program programObj = new Program();
            Case caseObj = new Case();

            Console.WriteLine("1.Add to the list");
            Console.WriteLine("2.Delete from the list");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter case no:");
                        caseObj.CaseNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter case code:");
                        caseObj.CaseCode = Console.ReadLine();
                        Console.WriteLine("Enter case content:");
                        caseObj.CaseContent = Console.ReadLine();
                        Console.WriteLine("Enter date:");
                        caseObj.Date = Convert.ToDateTime(Console.ReadLine());

                        bool result = programObj.AddToList(caseObj);
                        if(result == true)
                        {
                            Console.WriteLine("Added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Not added");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter case no:");
                        int caseNo = Convert.ToInt32(Console.ReadLine());
                        
                        bool result = programObj.DeleteFromList(caseNo);
                        if (result == true)
                        {
                            Console.WriteLine("Deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Not deleted");
                        }
                        break;
                    }
            }
        }
        
    }
}
