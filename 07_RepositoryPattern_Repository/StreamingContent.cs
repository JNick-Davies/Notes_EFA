using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller,
        Romance
    }
    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA
    }
    public class StreamingContent
    {
  
        public string Title { get; set; } //prop then tab tab change int to string
        public string Description { get; set; } //for streaming services
        public MaturityRating MaturityRating { get; set; }//pg 13, R, etc. first Maturityrating is now a type
        public int StarRating { get; set; } //full stars no half stars here
        public bool IsFamilyFriendly {
            get //build a switch case
            {
                switch (MaturityRating)//preference to use switch or can even use an if statement 
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                //Another way to do the above...cast method
                if ((int)MaturityRating > 1) //remeber how enums have value assigned ? this only works if enum is in order. 
                {
                    return false;
                }
                else
                {
                    return true;
                }
            } 
        }//is or is not T||F
        public GenreType TypeOfGenre { get; set; } //gaining access to the enum. This is now a property of streaming content

        public StreamingContent() { } //empty constructor
        public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating, GenreType typeOfGenre) //overloaded constructor **ctor tab will build out a constructor
        {
            Title = title; //defining variables
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;
        }

    }
}
