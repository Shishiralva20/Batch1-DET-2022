using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqLearning1
    {
        public static void Main()
        {
            LinqLearning();
        }
        private static void LinqLearning()
        {
            //1.DATA SOURCE
            List<string> place = new List<string>();
            place.Add("Mangalore");
            place.Add("Bangalore");
            place.Add("Mysore");
            place.Add("Mumbai");


            //2.QUERY CREATION
            //DEFERRED EXECUTION:
            //var numQuery = from num in numbers where num>100 select num;
            var PlaceQuery = from city in place select city;
            //EARLY EXECUTION:
            //var numQuery = (from num in numbers select num).ToList();
            place.Add("Delhi");
            place.Add("Punjab");

            //3.QUERY EXECUTION
            foreach (string city in PlaceQuery)
            {
                Console.WriteLine($"{city}");
            }
        }
    }
}

/*   internal class LinqLearning
   {*/

/*                    string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
        var result = names.Reverse();
        Console.WriteLine(result);*/

/* }*/
/*private static void Main1()
{
    List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "apple", "cheese" };

    //var wordGroups = from w in words
    //                  group w by w[0] into g
    //                  select new { FirstLetter = g.Key, Words = g};

    var wordGroups = words.GroupBy(x => x[0]).Select
        (y => new { FirstLetter = y.Key, Words = y });
    foreach (var item in wordGroups)
    {

        Console.WriteLine("Words that start with the" + "letter '{0}':", item.FirstLetter);

        foreach (var w in item.Words)
        {
            Console.WriteLine(w);
        }
    }*/
/*    }
}*/
/*    }
    public class EmployeeLinq
        {
            public EmployeeLinq()
            {

            }

*//*            public Employee(int id, string name, string dept)
            {
                this.ID = id;
                this.Name = name;
                this.Dept = dept;

            }*//*
            public int ID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

        
    }
}*/
/*        public static void Main()
        {
            EmployeeLinq e = new EmployeeLinq();
        }


 private static void SampleEmployedList()
{
    List<Employee> emps = GetListofEmployess();
    var emp_query = from employee in emps select employee;


    foreach (var item in emp_query)
    {
        Console.WriteLine("Name is " +)    
    }

}*/





























//Assignment - 1
/*        public static void Main()
        {
            string[] names = { "John","Peter","Jacob","Harry","Jackson" };
            var result = names.Where(names => names.Contains('O'));
            Console.WriteLine("Names Which contains O ");
            Console.WriteLine(result);
        }*/

/*static void Main()
{
    string[] capitals = { "John", "Peter", "Jacob", "Harry", "Jackson" };

    var res = capitals.OrderBy(c => c.Length);
    var result = capitals.Skip(4);

    Console.WriteLine("Name which has max no of character length:");
    foreach (string capital in result)
        Console.WriteLine(capital);
}*/



//COUNT
/*        private static void Main()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }*/


/* private static void Main()
 {
     //The Three parts of a LINQ Query: deffered execution
     // 1.Data source.
     List<int> numbers = new List<int>();
     numbers.Add(110);
     numbers.Add(100);
     numbers.Add(105);
     numbers.Add(102);
     numbers.Add(107);

     //2. Query creation. sql type

     //ex for deffered execution
     //var numQuery = from num in numbers // select num from numbers
     //            where num>102
     //            select num;


     //lamda exp
     //var numQuery = numbers.Select(x => x);

     *//*            //early execution
                 var numQuery = (from num in numbers // select num from numbers
                                 select num).ToList();*//*

     //lamda exp
     var numQuery = numbers.Where(x => x%2==1);
     // numbers.Add(200);
     //numbers.Add(210);
     //numbers.Add(221);


     //3. Query execution.


     foreach (int num in numQuery)
         {
         Console.Write("{0} ", num);
         //num.Dump(); // this is for LINQpad not for VS
         }
     Console.ReadLine();
 }      */

/*        public static void Main()
        {
            int[] numbers = { 7, 9, 5 };

            var result = numbers.OrderBy(n => n);

            Console.WriteLine("Ordered List of numbers:");
            foreach (int number in result)
                Console.WriteLine(number);
        }*/

/*        public static void Main()
        {
            string[] names = { "Ned", "Ben", "Susan" };

            var result = names.OrderByDescending(n => n);
            Console.WriteLine("Descending Ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);

        }*/

/*        public static void Main()
        {
            char[] characters={ 's','a','m','p','l','e'};

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach(char character in result)
                Console.WriteLine(character);
        }*/

/*        public static void Main()
        {
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
                                  "Athens", "Beijing", "Seoul" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }*/
/*
        public static void Main()
        {
            var dates = new DateTime[]
            {
                        new DateTime(2015, 3,1),
                        new DateTime(2014, 7,1),
                        new DateTime(2013, 5,1),
                        new DateTime(2015, 1,1),
                        new DateTime(2015, 7,1),
            };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }*/
//SKIP
/*        public static void Main()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(4);

            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result)
                Console.WriteLine(word);
        }*/

/*        //SKEPWHILE
        public static void Main()
        {
            string[] words = { "one", "two", "three", "four", "five", "six"};

            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }*/

//TAKE
/*        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Take(5);

            Console.WriteLine("Takes the first 5 numbers only:");
            foreach (int number in result)
                Console.WriteLine(number);
        }*/

//TAKEWHILE

/*
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Console.WriteLine(number);
        }*/


//AGGREGATION SIMPLE
/*        private static void Main()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }*/

//AVERAGE
/*         private static void Main()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }*/

//COUNT
/*        private static void Main()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }*/

//MAX
/*        private static void Main()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };
            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }*/

//MIN
/*        private static void Main()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };
            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }*/

//SUM
/*        private static void Main()
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }*/

//SET_DISTINCT
/*        private static void Main()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Console.WriteLine(number);
        }*/

//EXCEPT
/*        private static void Main()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Console.WriteLine(number);
        }*/

//INTERSECT
/*        private static void Main()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
*/
//UNION
/*        private static void Main()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }*/

//ELEMENT_AT
/*        private static void Main()
        {
            string[] words = { "One", "Two", "Three" };

            var result = words.ElementAt(1);

            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);
        }*/

//ElementAtOrDefault
/*        private static void Main()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }*/

//First_SIMPLE
/*        private static void Main()
        {
            string[] fruits = { "Banana", "Apple", "Orange" };

            var result = fruits.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }*/

//First_Conditional

/*        private static void Main()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };

            var result = countries.First(c => c.Length == 6);

            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result);
        }*/

//FirstorDefault

/*        private static void Main()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };

            var result = countries.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }*/

//Last

/*        private static void Main()
        {
            int[] numbers = { 7, 3, 5 };

            var result = numbers.Last();

           Console.WriteLine("Last number in array is:");
           Console.WriteLine(result);
        }*/

//LastOrDefaultSimple

/*        private static void Main()
        {
            string[] words = { "one", "two", "three" };
            string[] empty = { };

            var result = words.LastOrDefault();

            var resultEmpty = empty.LastOrDefault();

            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }*/

//LastOrDefaultConditional
/*        private static void Main()
        {
            string[] words = { "one", "two", "three" };

            var result = words.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }*/

//Single
/*        public static void Main()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.Single();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            try
            {
                // This will throw an exception because array contains no elements
                var resultEmpty = empty.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
*/
//SingleOrDefault
/*        public static void Main()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.SingleOrDefault();

            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
*/
//ALL
/*        public static void Main()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
    }*/

//ANY
/*        public static void Main()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
*/
//CONTAINS

/*        public static void Main()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);*/
/*        }
    }
}
*/