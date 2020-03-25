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
            Console.WriteLine(LengthWord("Welcome "));
            Console.ReadLine();
        }

        /// <summary>
        /// Cho một chuỗi s bao gồm các chữ cái in hoa / in thường và các ký tự khoảng trống . 
        /// Trả về độ dài của từ cuối cùng trong chuỗi.
        /// Nếu từ cuối cùng không tồn tại, trả về 0.
        /// Lưu ý: Một từ được định nghĩa là một chuỗi ký tự chỉ bao gồm các ký tự không phải khoảng trắng.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthWord(string s)
        {
            string[] arrays = s.Trim().Split(' ').ToArray();
            int n = arrays.Count();
            if (n <= 0)
                return 0;      
            return arrays[n - 1].Length;
        }

        /// <summary>
        /// Viết chương trình đưa ra biểu diễn chuỗi của các số từ 1 đến n.
        /// Nhưng đối với bội số của ba thì nên xuất ra "Fizz" thay vì số lượng và cho bội số của năm đầu ra "Buzz".
        /// Đối với các số là bội số của cả ba và năm đầu ra "FizzBuzz".
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static  string[] FizzBuzz(int n)
        {
            string[] result = new string[n];
            for (int i = 0; i < n; i++)
            {
                int temp = i + 1;
                if (temp % 15 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (temp % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (temp % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = temp.ToString();
                }
            }
            return result;
        }

        /// <summary>
        /// Cho một mảng không rỗng để biểu thị một số nguyên không âm. Cộng thêm 1 đơn vị vào số nguyên được biểu thị.
        /// Các chữ số được luu vào mảng sao cho số có ý nghĩ nhất nằm ở đầu, mỗi phần tử mảng lưu một chữ số.
        /// Ngầm hiểu: Phần tử đầu của mảng đầu ra luôn khác 0 (Không có số nguyên dương nào cộng 1 bằng 0).
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] Plus(int[] nums)
        {
            int number = 0;
            int n = nums.Count();
            for(int i = 0; i < n; i++)
            {
                number += (int)(Math.Pow(10, (n-i-1))* nums[i]);
            }
            number++;
            n = number.ToString().Length;
            int[] result = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                result[i] = (int) (number / Math.Pow(10, (n - i -1)));
                number = number - (int) (result[i] * Math.Pow(10, (n - i - 1)));
            }
            return result;
        }

        public static string ToLowerCase(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append(Char.ToLower(str[i]));

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
