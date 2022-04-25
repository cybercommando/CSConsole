using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Amazon
{
    public static class Demo
    {
        public static int[] cellComplete(int[] states, int days)
        {
            int size = states.Length;
            int[] Output = new int[size];

            for (int i = 0; i < days; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j <= 0)
                    {
                        //For First
                        if (states[j + 1] == 0)
                        {
                            Output[j] = 0;
                        }
                        else
                        {
                            Output[j] = 1;
                        }
                    }
                    else if (j >= (size - 1))
                    {
                        //For Last
                        if (states[j - 1] == 0)
                        {
                            Output[j] = 0;
                        }
                        else
                        {
                            Output[j] = 1;
                        }
                    }
                    else
                    {
                        if (states[j - 1] == states[j + 1])
                        {
                            Output[j] = 0;
                        }
                        else
                        {
                            Output[j] = 1;
                        }
                    }
                }
                Array.Copy(Output, states, size);
            }
            return Output;
        }

        public static int GCD(int[] Arr, int num)
        {
            return Arr.Aggregate(CalculateGCD);
        }
        private static int CalculateGCD(int a, int b)
        {
            return b == 0 ? a : CalculateGCD(b, a % b);
        }
    }
}
