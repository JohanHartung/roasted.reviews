using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasted.reviews
{
    internal class Ranking
    {
        Dictionary<Shop, float[]> ranking = new Dictionary<Shop, float[]>();

        public void Add(Shop shop)
        {
            ranking.Add(shop, shop.Rating().GetRating());
        }
        
    }
}
