using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Codility.Lessons
{
    public static class BinaryGap
    {
        public static int solution(int N)
        {
            var binaryValue = Convert.ToString(N, 2);
            int start = 0;
            foreach (var item in binaryValue)
            {
                if (item == '1')
                    break;
                start++;
            }
            var reverseBinary = binaryValue.Reverse();
            int end = 0;
            foreach (var item in reverseBinary)
            {
                if (item == '1')
                    break;
                end++;
            }
            return binaryValue.Substring(start, binaryValue.Length - end).Split('1').Select(x => x.Length).Max();
        }
    }
}
