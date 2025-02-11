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

            #region 5. Aggregate OPerators -Immediate Execution
            //// 5. Aggregate OPerators -Immediate Execution

            //// Count - Sum - Min - Avg

            ////var result = ProductList.Count;
            ////var result = ProductList.Count();

            ////var result = ProductList.Count(P => P.UnitsInStock == 0);   
            ////var result = ProductList.Where(P => P.UnitsInStock==0).Count();

            ////var result = ProductList.Sum(P => P.UnitPrice);
            //// var result = ProductList.Sum(P => P.UnitsInStock);

            ////var result = ProductList.Average(P => P.UnitPrice);

            ////var result = ProductList.Max();// At least one object must implement IComparable.

            ////var result = ProductList.Max(new ProductComparerUnitInStock());

            ////var result = ProductList.Max(P => P.UnitPrice);
            //// var result = ProductList.MaxBy(P => P.UnitPrice);

            ////var result = ProductList.MinBy(P => P.ProductName, new ProductComparerLenghtString());
            ////var result = ProductList.MaxBy(P => P.ProductName, new ProductComparerLenghtString());

            ////List<string> Names = new List<string>() { "Ahmed" , "Ail" , "Omer"};
            ////var result = Names.Aggregate((S01, S02) => $"{S01} {S02}");
            ////Console.WriteLine(result); 
            #endregion

            #region 6. Casting OPerators - Immediate Execution
            // 6. Casting OPerators - Immediate Execution

            //List<Product> result = (List<Product>) ProductList.Where(p => p.UnitsInStock == 0);//invaild
            // List<Product> result = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //Product[] result = ProductList.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> result = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);

            //HashSet< Product> result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();  
            #endregion

            #region 7. Generation OPerators 
            // 7. Generation OPerators 
            // the only way to call this method as -> class Member Method throught "enumerable Method "

            //Range - Empty - Repeat 

            //var result = Enumerable.Range(1, 100);

            //var result = Enumerable.Empty<Product>().ToList();
            //result.Add(new Product() { ProductName = "aaa" });

            //var result = Enumerable.Repeat(ProductList[0], 5); 
            #endregion

            #region 8. Set OPeration - Union Family

            // 8. Set OPeration - Union Family
            // Union - Union All - Intersect - Except

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100); 
            //var result = Seq01.Union(Seq02);// like Union in Sql Without Duplication

            //var result = Seq01.Concat(Seq02);// like Union in Sql With Duplication

            //var result = Seq01.Intersect(Seq02);

            //var result = Seq01.Except(Seq02); // 1 - 49
            // var result = Seq02.Except(Seq01); // 101 - 149
            // result.Distinct();//remove Duplication 
            #endregion

            #region 9. Quantifiers OPerators
            // 9. Quantifiers OPerators - Return Boolean

            // All - Any - SequnceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //Any() Return True if there are at least one element [ in sequence or match condition ]

            //var result = Seq01.Any();
            //var result = Seq01.Any(n => n % 2 == 0);
            //var result = ProductList.Any(P => P.UnitsInStock == 0);


            //All() => Return True if all element match condition or sequence is empty
            //var result = Seq01.All(n => n > 0);
            //var result = Seq01.All(n => n % 2 == 0);

            //var result = Seq01.SequenceEqual(Seq02);

            //var result = Seq01.Contains(1);
            //Console.WriteLine(result); 
            #endregion

            #region  10. Zipping Opertors
            // 10. Zipping Opertors 
            // List<string> Word = new List<string>() { "ten", "twenty", "thrity", "fourty" };
            // List<int>  Numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };

            //var result= Word.Zip(Numbers, (W, N) => $"{N} ----> {W}"); 
            #endregion

            #region 11. Groping Operators
            // 11. Groping Operators

            //var result = ProductList.GroupBy(P => P.Category);

            //var result = from P in ProductList
            //         group P by P.Category;

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0  
            //             group P by P.Category;

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 12
            //             select Category;

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //            into Category
            //             where Category.Count() > 5
            //             select new { NameCategory = Category.Key , CategoryCount = Category.Count() };

            //var result = ProductList.Where(P => P.UnitsInStock >0)
            //                        .GroupBy(P => P.Category)
            //                        .OrderBy(C => C.Count())
            //                        .Where(C => C.Count()>5)
            //                        .Select (C => new { NameCategory = C.Key, CategoryCount = C.Count() });


            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine(product);

            //    }
            //} 
            #endregion

            #region 12. Partioning -Take -TakeLast -Skip -SkipList -TakeWhile -SkipWhile

            // 12. Partioning -Take -TakeLast -Skip -SkipList -TakeWhile -SkipWhile

            //var result = ProductList.Take(3);
            // var result = ProductList.TakeLast(3);

            //var result = ProductList.Skip(5);
            //var result = ProductList.Skip(5).Take(5);
            // var result = ProductList.SkipLast(5);

            // int[] Numbers = { 9,4, 1, 2, 3, 4, 5 };
            //var result = Numbers.TakeWhile(n => n % 3 == 0);
            //var result = Numbers.SkipWhile(n => n % 3 == 0);

            // var result = Numbers.TakeWhile((N, I) => N > I);
            //var result = Numbers.SkipWhile((N, I) => N > I); 
            #endregion
            foreach (var item in result)
            {
                Console.WriteLine($"{item} ");

            }
        }
    }
}
