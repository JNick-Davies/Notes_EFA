using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title) //gets show by title 
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show)) //does title match?
                {
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title) //gets movie by title 
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content); //cast to show for the properties in show
                }
            }
            return allShows;
        }

        //get all movies method 
        public List<Movie> GetallMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }

        // Get by other parameters
        // Get by RunTime/AverageRunTime
        // Get Shows with over x episodes
        // Get Shows/Movie By Rating

        public List<Movie> GetAllMoviesByRunTime(double runTime) //parameters 
        {
            List<Movie> allRunTimes = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GetType() == typeof(Movie))
                {
                    Movie movieContent = (Movie)content; //recasting content from streaming content to type movie in the varible movie content 
                    if (movieContent.RunTime >= runTime)
                    {
                        allRunTimes.Add(movieContent);
                    }
                }
            } return allRunTimes;
        }



        /*public List<Show> GetAllShowsOverTenEpisodes (int episodeCount)
        {
            List<Show> episodeOverTen = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content is Show && episodeCount >= 10)
                {
                    episodeOverTen.Add();
                }
            }
        } 
        Return null;*/
        public Show GetAllShowsOverTenEpisodes(int episodeCount) //does this work??
        {
            foreach (Show content in _contentDirectory)
            {
                if (content.EpisodeCount == episodeCount)
                {
                    return content;
                }
            }return null;
        }
    } 
}

