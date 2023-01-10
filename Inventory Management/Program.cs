using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2 //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static List<Inventory> InventoryList = new List<Inventory>()
        {
            new Inventory { ProductId = "MLT44", ProductName = "Mi LED TV 4A 43inches", Quantity = 21, ProductPrice = 22999.87},
            new Inventory { ProductId = "S3SLMM", ProductName = "Samsung 32inches Smart LED Monitor MS", Quantity = 17, ProductPrice = 25077.64},
            new Inventory { ProductId = "A3SLFT", ProductName = "AmazonBasics 32inches Smart LED Fire TV", Quantity = 8, ProductPrice = 15898.50},
            new Inventory { ProductId = "O3LTY", ProductName = "Oneplus 32inches LED TV Y-Series", Quantity = 11, ProductPrice = 16356.98},
            new Inventory { ProductId = "L5USLT", ProductName = "LG 55inches UHD Smart LED TV", Quantity = 9, ProductPrice = 51866.90}
        };
        
        //Implement the methods here
        public List<Inventory> GetProductById(String productId)
        {
            var result = InventoryList.Where(w => w.ProductId == productId).ToList();
            List<Inventory> resultList = new List<Inventory>();

            foreach (var r in result)
                resultList.Add(new Inventory
                {
                    ProductId = r.ProductId,
                    ProductName = r.ProductName,
                    Quantity = r.Quantity,
                    ProductPrice = r.ProductPrice
                });

            return resultList;
                
        }

        public List<Inventory> SortByProductPrice()
        {
            var result = InventoryList.OrderBy(o => o.ProductPrice).ToList();

            List<Inventory> resultList = new List<Inventory>();

            foreach (var r in result)
                resultList.Add(new Inventory
                {
                    ProductId = r.ProductId,
                    ProductName = r.ProductName,
                    Quantity = r.Quantity,
                    ProductPrice = r.ProductPrice
                });

            return resultList;
        }
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Program prog = new Program();
            Console.WriteLine(InventoryList);
            while (true)
            {
                Console.WriteLine("1. Get Product By Id");
                Console.WriteLine("2. Sort by product price");
                Console.WriteLine("3. Exit");

                Console.WriteLine();
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1 :
                        {
                            Console.WriteLine("Enter the product id");
                            string id = Console.ReadLine();

                            List<Inventory> result = prog.GetProductById(id);

                            foreach (var r in result)
                                Console.WriteLine(r.ProductId + " " + r.ProductName + " " + " " + r.Quantity + " " + r.ProductPrice);

                            break;
                        }
                    case 2:
                        {
                            List<Inventory> result = prog.SortByProductPrice();

                            foreach (var r in result)
                                Console.WriteLine(r.ProductId + " " + r.ProductName + " " + " " + r.Quantity + " " + r.ProductPrice);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Thank you");
                            return;
                        }
                }
            }
        }
        
        public static ParameterExpression variableExpr_GetProductById = Expression.Variable(typeof(List<Inventory>), "sampleVar");
        public static Expression GetMyExpression(String productId)
        {
            {
                /** Copy ONLY the Query Expresion into the specified comment area and return the expression **/
                Expression assignExpr = Expression.Assign(variableExpr_GetProductById, Expression.Constant(InventoryList.Where(w => w.ProductId == productId).ToList()/**copy and paste the Linq query from the above method**/));
                return assignExpr;
            }
        }

        public static ParameterExpression variableExpr_SortByProductPrice = Expression.Variable(typeof(List<Inventory>), "sampleVar");
        public static Expression GetMyExpression1()
        {
            {
                /** Copy ONLY the Query Expresion into the specified comment area and return the expression **/
                Expression assignExpr = Expression.Assign(variableExpr_SortByProductPrice, Expression.Constant(InventoryList.OrderBy(o => o.ProductPrice).ToList()/**copy and paste the Linq query from the above method**/));
                return assignExpr;
            }
        }
    }
}
