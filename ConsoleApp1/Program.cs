using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.TwoSum(new int[] { 1, 2, 3 }, 4); // two_sum([1, 2, 3], 4) == {0, 2}
        }
    }

    public class Kata
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int sum = 0;
            int[] ints = new int[2];

            for (int j = 0; j < numbers.Length; j++)
            {
                sum = numbers[j];

                if (j+1 < numbers.Length)
                {
                    for (int i = j + 1; i < numbers.Length; i++)
                    {
                        sum += numbers[i];

                        if (sum == target)
                        {
                            ints[0] = j;
                            ints[1] = i;
                            break;
                        }

                        sum -= numbers[i];
                    }

                    if (sum == target)
                    {
                        break;
                    }
                }
                else
                {
                    throw new Exception("Not found");
                }

            }
            return ints;
        }
    }
}


