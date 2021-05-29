using System;
using System.Collections.Generic;


namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary!");

            // Creating
            Console.WriteLine("In Creating");
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            Console.WriteLine("-----------");

            // Creating & Initialization
            Console.WriteLine("In Creating & Initialization");

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1, "James" },
                {2, "Jack" },
                {3, "Emmet" },
            };

            foreach (var item in names)
            {
                Console.WriteLine("Item In Names = " + item.Key + " , " + item.Value);
            }


            Console.WriteLine("----------------------");

            // Add
            Console.WriteLine("In Adding");

            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");

            Console.WriteLine("----------------------");

            // Displaying
            Console.WriteLine("In Displaying");

            foreach (var item in capitals)
            {
                Console.WriteLine("Item " + item.Key + " , " + item.Value);
            }
            Console.WriteLine("----------------------");

            // Index
            Console.WriteLine("In Index");

            Console.WriteLine("Capital value from Russia Key = " + capitals["Russia"].ToString());
            Console.WriteLine("----------------------");

            // Capacity
            Console.WriteLine("In Capacity");
            Console.WriteLine("Current Capacity = " + capitals.Count);
            Console.WriteLine("----------------------");

            // Try Get Value
            Console.WriteLine("In Try To Get Value");

            capitals.TryGetValue("Germany", out string result);

            Console.WriteLine("Result from looking for Germany = " + result);
            Console.WriteLine("----------------------");

            // Remove
            Console.WriteLine("In Remove");

            capitals.Remove("Italy");
            Console.WriteLine("After removing Italy");

            foreach (var item in capitals)
            {
                Console.WriteLine("Item " + item.Key + " , " + item.Value);
            }

            Console.WriteLine("----------------------");

            // Contains
            Console.WriteLine("In Contains");

            Console.WriteLine("Contains Russia = " + capitals.ContainsKey("Russia"));
            Console.WriteLine("Contains France = " + capitals.ContainsKey("France"));

            Console.WriteLine("----------------------");

            // Remove All
            Console.WriteLine("In Remove All");

            capitals.Clear();

            Console.WriteLine("After removing all");
            foreach (var item in capitals)
            {
                Console.WriteLine("Item " + item.Key + " , " + item.Value);
            }

            Console.WriteLine("----------------------");

        }
    }
}
