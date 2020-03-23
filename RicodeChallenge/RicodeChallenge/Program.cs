using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
  

        public static string ToLowerCase(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    result.Append(Char.ToLower(str[i]));
                }
                else
                {
                    result.Append(str[i]);
                }
                
            }
            return result.ToString();
        }
        /// <summary>
        /// Chuỗi Tribonacci được định nghĩa như sau:
        /// T0 = 0, T1 = 1, T2 = 1 và Tn +3 = Tn + Tn + 1 + Tn + 2 với n> = 0.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Tribonacci(int n)
        {
            //Cho n, trả về giá trị của Tn.
            if (n <= 0)
            {
                return 0;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Tribonacci(n - 2) + Tribonacci(n - 1) + Tribonacci(n - 3);
            }
        }
        /// <summary>
        ///  Cho n và k, trả về chuỗi hoán vị thứ k.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        //public string hoanViThuN(int n, int k)
        //{
        //    List<string> hoanVis = new List<string>();
        //    while ()
        //    {
        //        n
        //    }
        //}
        /// <summary>
        /// Tìm phần tử lớn thứ k trong một mảng chưa sắp xếp.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindKthLargest(int[] nums, int k)
        {
            int n = nums.Length;
            // sort array
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                // Find the maximum element in unsorted array 
                for (int j = i + 1; j < n; j++)
                    if (nums[j] > nums[min_idx])
                        min_idx = j;
                // Swap the found minimum element with the first 
                // element 
                int temp = nums[min_idx];
                nums[min_idx] = nums[i];
                nums[i] = temp;
            }
            if (k >= n)
            {
                return 0;
            }

            return nums[k-1];
        }
    }
}
