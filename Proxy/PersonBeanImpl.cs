using System;
namespace Proxy
{
    public class PersonBeanImpl : IPersonBean
    {
        int ratingCount;
        int rating;
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Interests { get; set; }
        public int HotOrNotRating
        {
            get
            {
                return ratingCount == 0 ? 0 : rating / ratingCount;
            }
            set
            {
                rating += value;
                ratingCount++;
            }
        }
    }
}
