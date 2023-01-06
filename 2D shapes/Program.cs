using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Polygon poly = new Polygon();
            Hexagon hexa = new Hexagon();

            Console.WriteLine(poly.CreateShape());
            Console.WriteLine(hexa.CreateShape());

            Console.ReadLine();
        }
    }
}
