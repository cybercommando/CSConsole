using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Amazon
{
    public static class Question1
    {
        public static int countDecreasingRatings(int[] ratings)
        {
            int result = ratings.Length;
            List<int[]> powersets = new List<int[]>();
            for (int i = 2; i <= ratings.Length; i++)
            {
                var powerset = subset(ratings, i);
                foreach (var item in powerset)
                {
                    if (isDecreasing(item))
                    {
                        powersets.Add(item);
                    }
                }
            }

            result += powersets.Count;
            return result;
        }

        public static List<int[]> subset(int[] rating, int count)
        {
            List<int[]> result = new List<int[]>();
            for (int i = 0; i <= rating.Length - count; i++)
            {
                result.Add(new ArraySegment<int>(rating, i, count).ToArray());
            }
            return result;
        }
        public static bool isDecreasing(int[] rating)
        {
            for (int i = 1; i < rating.Length; i++)
            {
                if (rating[i - 1] - rating[i] != 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
