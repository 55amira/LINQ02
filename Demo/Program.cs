using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static Demo.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
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
            //             select new { NameCategory = Category.Key, CategoryCount = Category.Count() };

            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .OrderBy(C => C.Count())
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C => new { NameCategory = C.Key, CategoryCount = C.Count() });


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

            #region Let and Into
            // Let Into
            //Query Syntax

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Moma", "Aya", "Marim" };

            //var result = from Name in Names
            //             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            //             into NoVolName
            //             //int0 => Restart Query with introdecing New Range Variables()
            //             where NoVolName.Length > 3
            //             select NoVolName;  

            //var result = from Name in Names
            //           let NoVolName=  Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            //           //let  => Continue Query with Adding New Range Variables()
            //             where NoVolName.Length > 3
            //             select NoVolName; 
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}
            #endregion

            #region Assigment

            #region LINQ - Restriction Operators


            #region 1. Find all products that are out of stock.

            //var result = ProductList.Where(P => P.UnitsInStock == 0);


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((N, I) => N.Length > I);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}

            #endregion


            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //var result = ProductList.Where(P => P.UnitsInStock == 0).First();
            //Console.WriteLine(result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000, new Product() { ProductName = "Defult Name" });
            //Console.WriteLine(result);

            #endregion

            #region 3. Retrieve the second number greater than 5 


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(N => N > 5).Skip(1).First();

            //Console.WriteLine(result);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the 

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(N => N % 2 !=0);
            // Console.WriteLine(result);

            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var result1 = from C in CustomerList
            //             select C;


            //var result = CustomerList.GroupBy(C => C.Orders)
            //                         .OrderBy(O => O.Count())
            //                         .Select(C => new { C.Key, C.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}
            //var result = result1.Count();
            //Console.WriteLine(result);

            //var result = CustomerList.GroupBy(C => C.Orders)
            //                      .OrderBy(O => O.Count())
            //                      .Select(O => new { NameCategory = O.Key, CategoryCount = O.Count() });



            //var result = from C in CustomerList
            //             //from O in C.Orders
            //             select new
            //             {
            //                 C.CustomerName,
            //                 C.Count()
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}



            #endregion

            #region 3. Return a list of categories and how many products each has

            //var result = ProductList.GroupBy(P => P.Category)
            //                       .Select(C => new { NameCategory = C.Key, CategoryCount = C.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}

            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.Sum( w=> w.Length);

            //Console.WriteLine(result);
            #endregion

            #region  6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.Min(w => w.Length);
            //var result = Words.MinBy(w => w.Length);
            //Console.WriteLine(result);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // string[] Words = File.ReadAllLines("dictionary_english.txt");

            // //var result = Words.Max(w => w.Length);
            //var result = Words.MaxBy(w => w.Length);
            // Console.WriteLine(result);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.Average(w => w.Length);

            //Console.WriteLine(result);
            #endregion

            #region 9. Get the total units in stock for each product category.

            //var result = ProductList.Count( P => P.UnitsInStock > 0 );
            //Console.WriteLine(result);

            #endregion

            #region 10. Get the cheapest price among each category's products
            //var result = ProductList.Min(P => P.UnitPrice);
            //var result = ProductList.MinBy(P => P.UnitPrice);
            //Console.WriteLine(result);

            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             let cheapest = Category.Min(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 cheapestPrice = cheapest
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");

            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.

            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Select(P => new
            //                        {
            //                            expensivePrice = P.Max(P => P.UnitPrice)

            //                        });

            //var result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             let expensive = Category.Max(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 expensivePrice = expensive
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             let expensive = Category.MaxBy(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 expensivePrice = expensive
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 14. Get the average price of each category's products.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             let Average = Category.Average(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 AveragePrice = Average
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var result = from P in  ProductList
            //             orderby P.ProductName 
            //             select P;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .Select(P => new { P.ProductName, P.UnitPrice, P.UnitsInStock });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //List<int> Number = new List<int> { 8, 3, 7, 1, 5, 9, 2, 0, 4, 6 };


            //var result = Number.OrderBy(N => Arr[N].Length)  
            //.ThenBy(N => Arr[N])  
            //.ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(W => W.Length)
            //    .ThenBy( W => W ,StringComparer.OrdinalIgnoreCase);


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductList.OrderBy(P => P.Category)
            //                       .ThenByDescending(P => P.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(R => R[1] == 'i')
            //                .Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion
            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(W => new { Upper = W.ToUpper(), Lower = W.ToLower() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, -----> Lower: {item.Lower}");
            //}


            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList.Where(P => P.UnitsInStock > 5)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitsInStock,
            //                            Price = P.UnitPrice
            //                        });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion


            #region 4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((N, I) => N == I);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is Less than {item.B}");
            //}



            #endregion


            #region 6. Select all orders where the order total is less than 500.00.


            //  var result = CustomerList.SelectMany(C => C.Orders)
            //                          .Where(O => O.Total < 500);


            //  foreach (var item in result)
            //  {
            //      Console.WriteLine($"{item} ");
            //  }

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var result = CustomerList.SelectMany(C => C.Orders)
            //                          .Where(O => O.OrderDate.Year >= 1998);


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion



            #endregion

            #region LINQ - Set Operators


            #region 1. Find the unique Category names from Product List

            //var result = from P in ProductList
            //             select P.Category;

            //result.Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}


            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = ProductList.Select(P => P.ProductName[0])
            //                      .Concat(CustomerList.Select(C => C.CustomerName[0]));

            //result.Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var result = ProductList.Select(P => P.ProductName[0])
            //                      .Intersect(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = ProductList.Select(P => P.ProductName[0])
            //                      .Except(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result = ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName[^3..] : P.ProductName)
            //                      .Concat(CustomerList.Select(C => C.CustomerName.Length >= 3 ? C.CustomerName[^3..] : C.CustomerName));

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion
            #endregion

            #region LINQ - Partitioning Operators


            #region 1. Get the first 3 orders from customers in Washington

            //var result = (from C in CustomerList
            //             from O in C.Orders
            //             where C.Address == "Washington"
            //             select C).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var result = (from C in CustomerList
            //              from O in C.Orders
            //              where C.Address == "Washington"
            //              select C).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((N, I) => N >= I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result = numbers.SkipWhile((n, index) => n >= index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.Any(W => W.Contains("ei"));

            //Console.WriteLine(result);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into g
            //             where g.Any(p => p.UnitsInStock == 0)
            //             select g;


            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine(product);

            //    }
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into g
            //             where g.All(p => p.UnitsInStock > 0)
            //             select g;


            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine(product);

            //    }
            //}

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var num in group)
            //    {
            //        Console.WriteLine(num);
            //    }

            //}


            #endregion

            #region 2. Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input


            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.GroupBy(word => char.ToUpper(word[0]));


            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 3. Consider this Array as an Input String[] Arr = { "from", "salt", "earn", " last", "near", "form" };Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };


            //var result = Arr.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));


            //foreach (var group in result)
            //{

            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("..............");
            //}
            #endregion
            #endregion

            #endregion

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}


        }
    }
}
