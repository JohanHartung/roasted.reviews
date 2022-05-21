using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static roasted.reviews.ShopData;

namespace roasted.reviews
{
    internal class ShopHours
    {
        public static string[] dayNames = { 
            "Mon",
            "Tue", 
            "Wed", 
            "Thu", 
            "Fri", 
            "Sat", 
            "Sun" 
        };
        public static string[] hourNames = {
                "00:00",
                "00:30",
                "01:00",
                "01:30",
                "02:00",
                "02:30",
                "03:00",
                "03:30",
                "04:00",
                "04:30",
                "05:00",
                "05:30",
                "06:00",
                "06:30",
                "07:00",
                "07:30",
                "08:00",
                "08:30",
                "09:00",
                "09:30",
                "10:00",
                "10:30",
                "11:00",
                "11:30",
                "12:00",
                "12:30",
                "13:00",
                "13:30",
                "14:00",
                "14:30",
                "15:00",
                "15:30",
                "16:00",
                "16:30",
                "17:00",
                "17:30",
                "18:00",
                "18:30",
                "19:00",
                "19:30",
                "20:00",
                "20:30",
                "21:00",
                "21:30",
                "22:00",
                "22:30",
                "23:00",
                "23:30"
        };
        
        
        public static void Main()
        {
            
            encode(1, 16, 34);
            Console.WriteLine(decode(1));
        }
        public static void encode(int day, int open, int close)
        {
            for (int i = 0; i < 48; i++)
            {
                hours[day, i] = false;
            }
            for (int i = open; i < close; i++)
            {
                hours[day,i] = true;
            }
        }
        public static string decode(int day)
        {
            int start = 0;
            int end = 0;
            for (int i = 0; i < 48; i++)
            {
                if (start == 0 && hours[day, i]) 
                {
                    start = i;
                }
                if (start != 0 && end == 0 && !hours[day, i]) 
                {
                    end = i-1;
                }
            }

            return $"{dayNames[day]}, {hourNames[start]}-{hourNames[end]}";
        }
    }
}
