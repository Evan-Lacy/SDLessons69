using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository
{
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public Genre Genre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get //get only, not set, solely to not let users set the maturity rating
            {
                switch (MaturityRating) //this bool only exists when being called, it is not stored anywher
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    default:
                        return false;

                }
            }
        }
        //empty constructor
        public StreamingContent() { }
        //overloaded constructor
        public StreamingContent(string title, string description, double starRating, Genre genre, MaturityRating maturityRating)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            Genre = genre;
            MaturityRating = maturityRating;
        }


    }
    public enum Genre
    {
        Horror = 1,
        RomCom,
        SciFi,
        Action,
        Documentary,
        Musical,
        Drama,
        Mystery
    }

    public enum MaturityRating
    {
        G=1,
        PG,
        PG_13,
        R,
        NC_17
    }
}
