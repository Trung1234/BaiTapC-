using System;
using System.Collections.Generic;
using System.Linq;

namespace MeasureSpot
{
    class Program
    {
        static void Main(string[] args)
        {
            //prepare input          
            List<string> data = new List<string>()
            { "A","B", "C","K","L","M","N",
                "O","P", "Q","R","S","T","U", "V","W","AA","AB","AC","AF","AG" };
           
            List<string> alphabets = GetAlphabetList();

            // create list measure from input and alphabets list
            List<Measure> results = CreateListMeasure(data,alphabets);

            Console.WriteLine("We have list measure!");
            foreach (var result in results)
            {
                Console.WriteLine("Spot : {0} with Width = {1}", result.Spot, result.Width);
            }
            Console.ReadLine();
        }

        private static List<Measure> CreateListMeasure(List<string> data, List<string> alphabets)
        {
            List<Measure> results = new List<Measure>();
            // first width
            int left = 10;
            for (int i = 0; i < data.Count(); i++)
            {
                for (int j = 0; j < alphabets.Count(); j++)
                {

                    if (data[i].Length == 1)
                    {
                        if (data[i].Equals(alphabets[j]))
                        {
                            left = left + 40;
                            results.Add(new Measure
                            {
                                Spot = data[i],
                                Width = left
                            });
                        }
                    }
                    else
                    {
                        if (data[i].Equals(alphabets[j].Last().ToString()))
                        {
                            left = left + 40;
                            results.Add(new Measure
                            {
                                Spot = data[i],
                                Width = left
                            });
                        }
                    }
                    if (left > 880)
                    {
                        left = 10;
                    }
                }
            }

            return results;
        }

        private static List<string> GetAlphabetList()
        {
            return new List<string>()
            { "A","B", "C", "D","E","F",
                "G","H","I","J","K","L","M","N",
                "O","P", "Q","R","S","T","U", "V","W","X","Y","Z" };
        }
    }
}
