using System.Collections;
using System.Xml.Linq;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.filteration operation - where / oftype
            // 1.filteration operation - where / oftype
            // all product out stock

            // fluent syntax
            // var result = productlist.where(p => p.unitsinstock == 0);

            // query syntax [ query expertion ]
            //var result = from  p in productlist
            //             where p.unitsinstock ==0
            //             select p;

            // var result = productlist.where(p => p.category == "meat/poultry");

            //var result = from p in productlist
            //             where p.category == "meat/poultry"
            //             select p;

            //var result = productlist.where(p => p.unitsinstock > 0).where(p => p.category == "meat/poultry");
            //var result = productlist.where(p => p.unitsinstock > 0 &&  p.category == "meat/poultry");

            //var result = from p in productlist
            //             where p.unitsinstock > 0 && p.category == "meat/poultry"
            //             select p;

            // indexed where vaild in only fulent syntax
            //var result = productlist.where((p,i) => i < 10 && p.unitsinstock > 0);
            //var result = productlist.where((p, i) => i < 5 );
            //var result = productlist.where(p => p.unitsinstock > 0).where((p,i) => i < 5);

            //arraylist arraylist = new arraylist() { 1, 2, 3, "ahmed", "ali", 1.5, 2.3, 1.2f, 1.5m, productlist[0], productlist[1] };
            //var result = arraylist.oftype<string>(); 
            #endregion

            #region 2. Transformation Operators - Select / SelectMany
            // 2. Transformation Operators - Select / SelectMany

            //var result = ProductList.Select(P => P.ProductName);

            //var result = from P in ProductList
            //             select P.ProductName;

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.Category,
            //                            OldPrice = P.UnitPrice,
            //                            newPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //                        });

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 newPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //             };


            // var result = CustomerList.Select(C => C.Orders);
            //var result = CustomerList.SelectMany(C => C.Orders); // If One Of Property is sequnce

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where((P, I) => I < 5); 
            #endregion

            #region  3. Ordering Operator
            // 3. Ordering Operator
            // Sorting

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderBy(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.Category,
            //                        });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice)
            //                       .Select(P => new
            //                       {
            //                           P.ProductName,
            //                           P.UnitPrice,
            //                           P.Category,
            //                           P.UnitsInStock
            //                       });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                     .ThenBy(P => P.UnitPrice)
            //                    .Select(P => new
            //                    {
            //                        P.ProductName,
            //                        P.UnitPrice,
            //                        P.Category,
            //                        P.UnitsInStock
            //                    });

            //var result = ProductList.Where(P => P.Category == "Seafood")
            //    .OrderByDescending(P => P.UnitsInStock)
            //                     .ThenByDescending(P => P.UnitPrice)
            //                    .Select(P => new
            //                    {
            //                        P.ProductName,
            //                        P.UnitPrice,
            //                        P.Category,
            //                        P.UnitsInStock
            //                    });

            //var result = from P in ProductList
            //             where  P.Category == "Seafood"
            //             orderby P.UnitPrice , P.UnitsInStock > 0
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.Category,
            //                 P.UnitsInStock

            //             };

            //var result = ProductList.Reverse<Product>(); 
            #endregion

            #region 4. Elements Operators  - Immediate Execution
            // 4. Elements Operators  - Immediate Execution

            //ProductList = new List<Product>();

            // var result = ProductList.First(); // May throw Exception [ Sequence contains no elements ]
            // var result = ProductList.Last();// May throw Exception [ Sequence contains no elements ]

            //var result = ProductList.First(P => P.UnitsInStock >10000);// May throw Exception Sequence contains no matching element
            //var result = ProductList.Last(P => P.UnitsInStock > 10);/// May throw Exception [ Sequence contains no elements ]

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName = " aaaa"});
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 10000);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 10000, new Product() { ProductName = " aaaa" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = " aaaa"});
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 10000);
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 10000, new Product() { ProductName = " aaaa" });

            //var result = ProductList.ElementAt(0);// May Throw Exception [ Index was out of range. Must be non-negative and less than the size of the collection ]
            //var result = ProductList.ElementAtOrDefault(0);

            // ProductList = new List<Product>() { new Product() { ProductName = " one only  Product" }};
            //var result = ProductList.Single();
            // May throw exception Sequence contains no elements
            // May throw exception Sequence contains more than one element

            //var result = ProductList.Single(P => P.UnitsInStock == 0);
            // May throw exception Sequence contains no matching element
            // May throw exception Sequence contains more than one matching element

            //var result = ProductList.SingleOrDefault();
            // May throw exception Sequence contains more than one element
            // Return Value [Null] If the Sequence is Empty

            // var result = ProductList.SingleOrDefault(new Product() { ProductName = "Defult Value" });
            // May throw exception Sequence contains more than one element
            // Return Value [new Product() { ProductName = "Defult Value" }] If the Sequence is Empty

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);
            // May throw exception Sequence contains more than one element
            // Return Value [Null] If the Sequence is Empty

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0 , new Product() { ProductName = "Defult Value" });
            // May throw exception Sequence contains more than one element
            // Return Value [new Product() { ProductName = "Defult Value" }] If the Sequence is Empty

            //var result = ProductList.DefaultIfEmpty();

            // Console.WriteLine(result?.ProductName ?? "Na"); 
            #endregion

            foreach (var unit in result)
            {
                Console.WriteLine(unit);
            }

        }
    }
}
