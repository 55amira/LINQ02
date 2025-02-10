using System.Collections;
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
            foreach (var unit in result)
            {
                Console.WriteLine(unit);
            }

        }
    }
}
