using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a dictionary variable and add key value pairs to it 
            //pass it 2 things. first is type of key, second is the type of the value 
            Dictionary<string, int> cohortCount =
                new Dictionary<string, int>();

            cohortCount.Add("Cohort 34", 20);
            cohortCount.Add("Cohort 35", 14);
            cohortCount.Add("Cohort 36", 28);
            cohortCount.Add("Cohort 37", 28);

            //want to iterate over key value pairs
            //type is keyValuePair

            foreach (KeyValuePair<string, int> item in cohortCount)
            {
                Console.WriteLine($"{item.Key} has {item.Value} students");
            }

            //Another way to declare a dictionary 
            Dictionary<string, double> products = new Dictionary<string, double>() { { "Deodorant", 4.5 }, { "Hair Brush", 8 }, { "Heidi Hair Brush", 5.25 }, { "Shampoo", 4.5 }, { "Tooth Brush", 40 } };

            //want to iterate over these and write to console something like deodorant cost 4.50

            foreach (KeyValuePair<string, double> product in products)
            {
                Console.WriteLine($"{product.Key} costs ${product.Value}");
            }
        }
    }
}