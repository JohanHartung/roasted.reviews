using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasted.reviews
{
    internal class Review
    {
        private static string[] type = { "Roast quality", "Brew quality", "Service quality", "Ambience", "Variety", "Classics", "Specials" };
        private float[] rating = new float[type.Length];
        private Dictionary<string, float>[] ratings = new Dictionary<string, float>[type.Length];

        public void Update()
        {
            CalcRatings();
        }

        //constructors
        public void NewReview(string userId, float rtg, int i)
        {
            ratings[i].Add(userId, rtg);
        }

        //internal stuff
        private void CalcRatings()
        {
            for(int i = 0; i < rating.Length; i++)
            {
                rating[i] = ratings[i].Values.Average();
            }
        }
    }
}
