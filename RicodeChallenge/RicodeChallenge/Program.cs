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
            // int[] arr = new int[] { 3, 2, 1, 5, 6, 4 };
            // Console.WriteLine(FindKthLargest(arr, 3));
            //Tập [1,2,3, ..., n] chứa n! hoán vị độc đáo
            //Bằng cách liệt kê và dán nhãn tất cả các hoán vị theo thứ tự, 
            //chúng tôi nhận được chuỗi sau cho n = 3:
            
            Console.ReadLine();
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
