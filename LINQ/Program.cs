using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ - Language Integrated Query

            int[] numbers = {46,11,23,53,65,25,655,89,78,45,34};

            // Method syntax
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            // Query expression syntax
            var result2 = from num in numbers
                            where num > 50
                            select num;

            // Restrictions - where
            var result3 = from num in numbers
                            where num > 50 && num<70
                            select num;

            // Projections - select
            var result4 = from num in numbers
                            where num % 2 == 0
                            select num * num;

            // Ordering - orderby, orderby descending
            var result5 = from num in numbers
                            orderby num descending
                            select num;

            // Partitioning : take, skip

            //takes first 5
            var resulta = numbers.Take(5);

            //first 5 paxadi ko linxa
            var result6 = numbers.Skip(5).Take(5);

            // Quantifiers : any, all, contains
            var result7 = numbers.Any(x => x % 2 == 0);

            var result8 = numbers.All(x => x % 2 == 0);
            
            var result9 = numbers.Contains(46);

            // Generations
            var result10 = Enumerable.Range(1, 1000);

            var result11 = Enumerable.Repeat("Hello World", 20);

            Program a = new Program();
            a.LearnLINQOnComplexCollection();

        }

        void LearnLINQOnComplexCollection()
        {
            Country c1 = new Country("Nepal", "Kathmandu", "Asia", 561246877);
            Country c2 = new Country("India", "Delhi", "Asia", 5616235467877, DateTime.Parse("1947/11/1"));
            Country c3 = new Country("England", "GB", "Europe", 3748565877);
            Country c4 = new Country("Bhutan", "Thimpu", "Asia", 246877);
            Country c5 = new Country("Russia", "Mosco", "Europe", 56877, DateTime.Parse("1937/12/1"));
            Country c6 = new Country("Australia", "Canberra", "Australia", 123561246877, DateTime.Parse("1907/4/1"));
            Country c7 = new Country("China", "Beijing", "Asia", 5324561246877);
            Country c8 = new Country("Greenland", "Nuuk", "Antartica", 98657561246877);
            Country c9 = new Country("Bangladesh", "Dhaka", "Asia", 53561246877, DateTime.Parse("1945/4/15"));
            Country c10 = new Country("Pakistan", "Islamabaad", "Asia", 566877, DateTime.Parse("1967/5/1"));
            Country c11 = new Country("Maldives", "Male", "Asia", 5687541246877, DateTime.Parse("1908/4/1"));
            Country c12 = new Country("Canada", "Ottawa", "North America", 5246877);
            Country c13 = new Country("US", "Wasington DC", "North America", 456561246877, DateTime.Parse("1923/4/11"));
            Country c14 = new Country("Newzealand", "Wellington", "Oceania", 56128777);
            Country c15 = new Country("Norway", "Oslo", "Europe", 36565);
            Country c16 = new Country("Egypt", "Cairo", "Africa", 2653531246877);
            Country c17 = new Country("Nygeria", "Abuja", "Africa", 5742346877, DateTime.Parse("1957/9/18"));
            Country c18 = new Country("Germany", "Berlin", "Europe", 51237);
            Country c19 = new Country("France", "Paris", "Europe", 46237);
            Country c20 = new Country("Italy", "Rome", "Europe", 3625656877, DateTime.Parse("1997/9/16"));





            List<Country> countries = new List<Country> {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20};

            //List all asian country names
            var result1= from country in countries
                            where country.Continent == "Asia"
                            select country.Name;

            // HW - List all asian country names which are never been invaded
            var result2 = from country in countries
                            where country.Continent == "Asia" && country.IndependanceDay == default
                            select country.Name;
            
            Console.WriteLine("Asian Countries");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            // HW - List all europian countries in ascending order that has population less than 500k
            var result3 = from country in countries
                            where country.Continent == "Europe" && country.Population<500000
                            orderby country.Population
                            select country;

            Console.WriteLine("Europian Countries");
            foreach (var item in result3)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
