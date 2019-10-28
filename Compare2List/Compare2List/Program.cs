using System;
using System.Collections.Generic;
using System.Linq;

namespace Compare2List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List1 = new List<string>() { "Apple", "Banana", "Carrot", "Grape", "Plum" };
            List<string> List2 = new List<string>() { "Apple", "Carrot", "Grape", "Mango", "Plum" };

            var result = List1.Concat(List2) //concatenate list into single recordset
                    .Except(List1.Intersect(List2)) //eliminate common items
                    .Select(a => new
                    {
                        Value = a, //get value
                        List = List1.Any(c => c == a) ? "List1" : "List2" //define list
                    });

            foreach (var d in result)
            {
                Console.WriteLine("Item: '{0}' found on: '{1}'", d.Value, d.List);
            }
        }
    }
}
