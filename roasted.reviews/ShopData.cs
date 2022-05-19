using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasted.reviews
{
    internal class ShopData
    {
        public static (string name, string id) shop;
        public static (string address, string email, string phoneNum) contact;
        public static (string overall, string[] category) results;
        public static (string[] item, string[] prize, string[] rating) menu;
        public static bool[,] hours = new bool[7, 48]; 
    }
}
