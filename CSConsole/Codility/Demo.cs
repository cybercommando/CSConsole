using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Codility
{
    public static class Demo
    {
        // Code for Finding First non existing positive integer in an array.
        public static int solution(int[] A)
        {
            A = A.Where(x => x > 0).Distinct().OrderBy(y => y).ToArray<int>();
            if (A.Length > 1)
            {
                if (A[0] == 1)
                {
                    for (int i = 1; i < A.Length; i++)
                    {
                        if (A[i - 1] == A[i] - 1)
                        {
                            continue;
                        }
                        else
                        {
                            return A[i - 1] + 1;
                        }
                    }
                    return A.Max() + 1;
                }
            }
            if (A.Length == 1)
            {
                if (A[0] == 1)
                    return 2;
                else
                    return 1;
            }
            else
            {
                return 1;
            }
        }

        //static int solution(int[] A)
        //{
        //    int max = A.Max();
        //    for (int i = 1; i <= max; i++)
        //    {
        //        if (!A.Contains(i))
        //        {
        //            return i;
        //        }
        //    }
        //    return (max <= 0) ? 1 : max + 1;
        //}
    }
}
