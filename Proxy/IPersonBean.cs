using System;
namespace Proxy
{
    public interface IPersonBean
    {
        string Name
        {
            get;
            set;
        }
        string Gender
        {
            get;
            set;
        }
        string Interests
        {
            get;
            set;
        }
        int HotOrNotRating
        {
            get;
            set;
        }
    }
}
