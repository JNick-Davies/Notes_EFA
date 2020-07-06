using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>(); //fake database 

        //CRUD .. moving down 
        public bool AddContentToDirectory(StreamingContent content) //create (CRUD)
        {
            int startingCount = _contentDirectory.Count; //how many things are in the directory 
            _contentDirectory.Add(content); //adding content to directory 
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;//ternary statement
            return wasAdded;
        }
        public List<StreamingContent> GetContents() //read (CRUD)
        {
            return _contentDirectory;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)//StreamingContent == var
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;//this return is not the best practice. 
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        //build methods that accomplish
        //get by rating 
        //get by other parameters --description
        //get by family friendly -- harder one ..return all that apply 
        //etc

        public List<StreamingContent> GetByIsFamilyFriendly(bool isFamilyFriendly) //get by family friendly 
        {
            List<StreamingContent> sortedList = new List<StreamingContent>();
            foreach(StreamingContent content in _contentDirectory)
            {
                sortedList.Add(content);
            }
            return sortedList;
        }
    }
}
