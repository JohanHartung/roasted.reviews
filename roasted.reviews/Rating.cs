using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasted.reviews
{
    public class Rating
    {
        private static string[] type = { "Roast", "Brew", "Service", "Ambience", "Variety", "Classics", "Specialties", "Overall" };
        private float[] rating = new float[type.Length];
        private Dictionary<string, float>[] userRatings = new Dictionary<string, float>[type.Length];

        public void Update()
        {
            CalcRatings();
        }

        //constructors
        public void NewRating(string userId, float rtg, int i)
        {
            userRatings[i].Add(userId, rtg);
        }
        public float[] GetRating()
        {
            return rating;
        }
        public float GetRating(int i)
        {
            return rating[i];
        }

        //internal stuff
        private void CalcRatings()
        {
            //calulate rating categories
            for(int i = 0; i < rating.Length; i++)
            {
                rating[i] = userRatings[i].Values.Average();
            }
            //calculate overall rating
            for (int i = 0; i < rating.Length-1; i++)
            {
                rating[rating.Length - 1] += rating[i];
            }
            rating[rating.Length - 1] /= rating.Length - 1;
        }
    }
}
