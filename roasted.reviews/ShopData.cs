using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace roasted.reviews
{
    internal class ShopData
    {
        private (string name, string id, Location geo) shop;
        private (string address, string email, string phoneNum) contact;
        private (string overall, string[] category) results;
        private (string[] item, string[] prize, string[] rating) menu;
        private (string name, string id, int level, bool active)[,] awards;
        private bool[,] hours = new bool[7, 48];
        
    }
}
