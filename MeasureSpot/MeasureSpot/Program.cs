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
                "O","P", "Q","R","S","T",
                "U", "V","W","X","Y","Z",
                "AA","AB","AC","AF","AG" };
            DateTime startTime = DateTime.Now;
            List<string> alphabets = GetAlphabetList();

            // create list measure from input and alphabets list
            List<Measure> results = CreateListMeasure(data,alphabets);

            Console.WriteLine("We have list measure!");
            foreach (var result in results)
            {
                Console.WriteLine("Spot : {0} with Width = {1}", result.Spot, result.Width);
            }
            Console.WriteLine("Total time : {0}",(DateTime.Now - startTime).TotalSeconds);

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
                    if (data[i].Equals(alphabets[j]))
                    {
                        left +=  40;
                        if (left > 880)
                        {
                            left = 10;
                        }
                        results.Add(new Measure
                        {
                            Spot = data[i],
                            Width = left
                        });
                    }                   
                }
            }

            return results;
        }

        /// <summary>
        /// get list from A to Z and lists from {AA .. AZ} to {ZA .. ZZ}
        /// </summary>
        /// <returns></returns>
        private static List<string> GetAlphabetList()
        {
            List<string> result = new List<string>();
            char index = 'A';
            for (index = 'A'; index <= 'Z'; index++)
                result.Add(index.ToString());

            char i='A';
            char j = 'A';
            for (i = 'A'; i <= 'Z'; i++)
            {
                for (j = 'A'; j <= 'Z'; j++)
                {
                    result.Add(i.ToString()+j.ToString());
                }
            }
            return result;
        }
    }
}
