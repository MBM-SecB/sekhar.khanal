using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //LINQ-- Language INtegrated Query

        int[] numbers = { 14, 745, 67, 34, 97, 48, 12, 39, 23, 582, 190 };

        // Methos Syntax
        var result1 = numbers.Where(num => num > 50).Select(num => num);

        // Query expression syntax
        var result2 = from num in numbers
                      where num > 50
                      select num;

        // Restrcitions -where
        var result3 = from num in numbers
                      where num > 50 & num < 70
                      select num;

        // Projections - select
        var result4 = from num in numbers
                      where num % 2 == 0
                      select num * num;

        // Ordering --orderby
        var result5 = from num in numbers
                      orderby num descending
                      select num;

        // Partitioning -- take, skip
        var result6 = numbers.Skip(5).Take(5);


        var result7 = numbers.Any(num => num % 2 == 0);
        var result8 = numbers.All(num => num % 2 == 0);
        var result29 = numbers.Contains(23);

        // // Genrations

        var result10 = Enumerable.Range(1, 1000);
        var result11 = Enumerable.Repeat("Hello Wolrd!", 20);


        void LearnLinqOnComplexCollection()
        {
            Country c1 = new Country("Nepal", "Kathmandu", "Asia", 1234567);
            Country c2 = new Country("India", "New Delhi", "Asia", 5746563, DateTime.Parse("1947/11/1"));
            Country c3 = new Country("Bhutan", "Thimpu", "Asia", 454564, DateTime.Parse("1947/11/1"));
            Country c5 = new Country("Afganistan", "Kabul", "Asia", 300000, DateTime.Parse("1947/11/1"));
            Country c6 = new Country("England", "GB", "Europe", 54324564);
            Country c7 = new Country("Russia", "Moscow", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c8 = new Country("Albania", "Mariehamn", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c9 = new Country("Belgium", "Brussels", "Europe", 440000, DateTime.Parse("1947/11/1"));
            Country c10 = new Country("Denmark", "Copenhagen", "Europe", 400000, DateTime.Parse("1947/11/1"));
            Country c11 = new Country("Finland", "Helsinki", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c12 = new Country("Germany", "Berlin", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c13 = new Country("France", "Paris", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c14 = new Country("Italy", "Rome", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c15 = new Country("Netherlands", "Amsterdam", "Europe", 450000, DateTime.Parse("1947/11/1"));
            Country c16 = new Country("Poland", "Warsaw", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c17 = new Country("Nigeria", "Abuja", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c18 = new Country("Ghana", "Accra", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c19 = new Country("Eritrea", "Asmara", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c20 = new Country("South Sudan", "Juba", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c21 = new Country("Morocco", "Rabat", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c22 = new Country("China", "Beijing", "Asia", 54324564, DateTime.Parse("1947/11/1"));
            Country c23 = new Country("Pakistan", "Islamabad", "Asia", 54324564, DateTime.Parse("1947/11/1"));

            var countries = new List<Country> {c1,c2,c3,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23};


            // List all asian country names
            var result12 = from country in countries
                           where country.Continent == "Asia"
                           select country.Name;

            // List all asian Countries which are never been invaded
            var result13 = from country in countries
                           where country.IndependenceDay == default
                           select country.Name;

            var result14 = from country in countries
                           where country.Population<500000 & country.Continent =="Europe"
                           select country.Name;
            Console.WriteLine("Countries that has never been invaded are: ");
            foreach (var name in result13)
            {
                
                Console.WriteLine(name);
            }

            Console.WriteLine("Europian countries that has population less than 500k are: ");
            foreach (var name in result14)
            {
                
                Console.WriteLine(name);
            }


            // List all europian countries in ascending order that has population less than 500k
            // COuntries never been invaded

        }
        LearnLinqOnComplexCollection();

    }
}

