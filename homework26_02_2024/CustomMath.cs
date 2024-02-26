using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework26_02_2024
{
    internal class CustomMath
    {
        public int GetSumOfArrayItem(int[] nums) => nums.Where(m => m % 2 == 1).Sum();

        public string CHeckNumberByEvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Tekdir";


        public double SquereOfEvenNumbers(int[] nums) => Math.Pow(nums.Where(m => m % 2 == 0).Sum(), 2);
       
        public int MultipleOfNumbers(int n)
        {
            int multiple = 1;
            for (int i = 1; i <= n; i++)
            {
                multiple *= i;
            }

            return multiple;
        }

          
    }
}
