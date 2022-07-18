using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace roasted.reviews
{
    public class Shop
    {
        private (string name, string id, Location geo) data;
        private (string address, string email, string phoneNum) contact;
        private (string name, string price, float rating)[] menu;
        private Rating reviews;

        public string Name()
        {
            return data.name;
        }
        public void Name(string name)
        {
            data.name = name;
        }
        public string Id() 
        { 
            return data.id; 
        }
        public void Id(string id)
        {
            data.id = id;
        }
        public Location Geo()
        {
            return data.geo;
        }
        public void Geo(Location geo)
        {
            data.geo = geo;
        }
        public string Address()
        {
            return contact.address;
        }
        public void Address(string address)
        {
            contact.address = address;
        }
        public string Email()
        {
            return contact.email;
        }
        public void Email(string email) 
        { 
            contact.email = email; 
        }
        public string PhoneNum()
        {
            return contact.phoneNum;
        }
        public void PhoneNum(string phoneNum)
        {
            contact.phoneNum = phoneNum;
        }
        public (string item, string price, float rating)[] Menu()
        {
            return menu;
        }
        public void Menu((string name, string price, float rating)item, int i)
        {
            menu[i] = item;
        }
        public void MenuItem(string name, int i)
        {
            menu[i].name = name;
        }
        public void MenuPrice(string price, int i)
        {
            menu[i].price = price;
        }
        public void MenuRating(float rating, int i)
        {
            menu[i].rating = rating;
        }

        public Rating Rating()
        {
            return reviews;
        }
        public void Rating(string r)
        {

        }
    }
}
