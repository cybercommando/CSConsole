using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Codility
{
    public static class FrogJmp
    {
        public static int solution(int X, int Y, int D)
        {
            return (Y - X) / D + ((Y - X) % D == 0 ? 0 : 1);
        }
    }
}
