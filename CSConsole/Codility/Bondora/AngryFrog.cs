using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Codility.Bondora
{
    public static class AngryFrog
    {
        public static int solution(int[] blocks)
        {
            int result = 0;
            if (blocks.Length <= 2)
                return 2;
            for (int i = 0; i < blocks.Length; i++)
            {
                int dist = distance(blocks, i);
                if (result <= dist)
                {
                    result = dist;
                }
            }
            return result;
        }
        public static int distance(int[] blocks, int index)
        {
            int startIndex = index;
            int endIndex = index;
            for (int i = index; i > 0; i--)
            {
                if (blocks[i - 1] >= blocks[i])
                {
                    startIndex = i - 1;
                }
                else
                {
                    break;
                }
            }
            for (int i = index; i < blocks.Length - 1; i++)
            {
                if (blocks[i + 1] >= blocks[i])
                {
                    endIndex = i + 1;
                }
                else
                {
                    break;
                }
            }
            return endIndex - startIndex + 1;
        }
    }
}
