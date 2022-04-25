using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Codility
{
    public static class ParkingBill
    {
        public static int solution(string E, string L)
        {
            int result = 2;
            var CurrentDate = DateTime.Now;
            DateTime date1 = new DateTime(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day, DateTime.Parse(E).Hour, DateTime.Parse(E).Minute, 0);
            DateTime date2 = new DateTime(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day, DateTime.Parse(L).Hour, DateTime.Parse(L).Minute, 0);
            TimeSpan ts = date2 - date1;
            var hours = ts.Hours;
            var minutes = ts.Minutes;
            if (hours <= 0 & minutes >= 0)
                result += 3;
            else
                result += 3 + ((hours - 1) * 4) + ((minutes > 0) ? 4 : 0);
            return result;
        }
    }
}
