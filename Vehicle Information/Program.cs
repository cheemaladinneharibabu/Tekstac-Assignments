using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Linq_1 //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static List<Vehicle> VehicleDetails = new List<Vehicle>
            {
                new Vehicle { VehicleNo = "US", VehicleType = "2 Wheeler", Insured = "Yes" },
                new Vehicle { VehicleNo = "OH", VehicleType = "2 Wheeler", Insured = "Yes" },
                new Vehicle { VehicleNo = "CL", VehicleType = "4 Wheeler", Insured = "No" },
                new Vehicle { VehicleNo = "TX", VehicleType = "2 Wheeler", Insured = "No" },
                new Vehicle { VehicleNo = "CT", VehicleType = "4 Wheeler", Insured = "Yes" },
                new Vehicle { VehicleNo = "OR", VehicleType = "4 Wheeler", Insured = "Yes" }
            };
            
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Program programObj = new Program();

            Console.WriteLine("Enter the vehicle type:");
            String vehicleType = Console.ReadLine();
            Console.WriteLine("Is it insured:");
            String insured = Console.ReadLine();

            List<Vehicle> result = programObj.DisplayVehicles(vehicleType, insured);
            foreach(var item in result)
            {
                Console.WriteLine(item.VehicleNo + " " + item.VehicleType + " " + item.Insured);
            }
        }
        
        //Implement the method here
        public List<Vehicle> DisplayVehicles(String vehicleType, string insured)
        {
            List<Vehicle> result = new List<Vehicle>();
            result = Program.VehicleDetails.Where(c => c.VehicleType == vehicleType && c.Insured == insured).ToList();
            return result;
        }
        
        public static ParameterExpression variableExpr = Expression.Variable(typeof(List<Vehicle>), "sampleVar");
        public static Expression GetMyExpression(String vehicleType, String insured)
        {
            {
                /** Copy ONLY the Query Expresion into the below comment area **/
                Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(Program.VehicleDetails.Where(c => c.VehicleType == vehicleType && c.Insured == insured).ToList()/** Copy ONLY the Query Expresion **/));
                return assignExpr;
            }
        }
    }
}
