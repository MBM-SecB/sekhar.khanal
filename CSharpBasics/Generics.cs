using System;
using System.Collections.Generic;

namespace LearningClasses
{
    public class Generic
    {
        //using list
        void LearningList()
        {
            List<string> names=new List<string>();
            names.Add("Sabita Sitaula");
            names.Add("Sabita Sitaula");
            names.Add("Sabita Sitaula");
            names.Add("Sabita Sitaula");

            //var x=names.Find(y=>y.StartsWith("Sab"));

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }

        void LearningDictionary()
        {
            Dictionary<string, string>countryCapitals=new Dictionary<string, string>();
            countryCapitals.Add("Nepal","Kathmandu");
            countryCapitals.Add("India","Delhi");

            foreach(var countryCapital in countryCapitals)
            {
                Console.WriteLine(countryCapital.Key);
                Console.WriteLine(countryCapital.Value);

            }

        }

    }
}