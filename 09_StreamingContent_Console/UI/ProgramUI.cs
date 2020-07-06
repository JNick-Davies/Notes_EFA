using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI//remember public 
    {
        private readonly IConsole _console; 
        private readonly StreamingRepository _streamingRepo = new StreamingRepository(); //this is important bc when we run this program this creates a streaming repo and pursistes for the length of the program. 
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        
        public void Run()//how we enter this class
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()//start menu, we;re trying to create a path for the user. Control what they see
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" + // '\n' reps a new line 
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by tite \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit"); //this follows crud 
                string userInput = _console.ReadLine();
                switch (userInput) //could use if 
                {
                    case "1":
                        //show all
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        //find by title
                        break;
                    case "3":
                        //add new
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        //remove
                        break;
                    case "5":
                        //exit
                        continueToRun = false; //could build a clsoing method like a y/n are you sure?
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue...");
                        _console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewContent()
        {
            _console.Clear();
            StreamingContent content = new StreamingContent(); //ref to 07_
            // title
            _console.WriteLine("Please enter the title of the content: ");
            content.Title = _console.ReadLine(); //readline always returns a string 

            //decription
            _console.WriteLine("Please enter the description of the content: ");
            content.Description = _console.ReadLine();

            //Maturity rating
            _console.WriteLine("Please Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG-13 \n" +
                "4) R \n" +
                "5) NC-17 \n" +
                "6) TV-MA");
            string maturityString = _console.ReadLine();
            switch (maturityString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }
            //star rating --int--
            _console.WriteLine("Please enter the star rating (1-5): ");
            content.StarRating = int.Parse(_console.ReadLine()); //parse is similar to casting turns string to int 

            // type of genre 
            _console.WriteLine("Please enter the Maturity Rating of the content: "); //remember enum 
            _console.WriteLine("Select a Genre: \n" +
                "1: Horror \n" +
                "2: Sci-Fi \n" +
                "3: Drama \n" +
                "4: Action \n" +
                "5: Comedy \n" +
                "6: Anime \n" +
                "7: Documentary \n" +
                "8: Thriller \n" +
                "9: Romance");
            string genreInput = _console.ReadLine(); //this works in leiu of the switch case 
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID; //<--casting taking an int and casting to an enum 
            _streamingRepo.AddContentToDirectory(content);//now this a part of the content directory 
        }
        private void ShowAllContent()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();

            foreach (StreamingContent contentVariable in listOfContent) //for each loop, what is collection made out of 
            {
                DisplayContent(contentVariable);
                _console.WriteLine("--------------");
                //_console.WriteLine($"{contentVariable.Title} {contentVariable.Description}");//going thru every single item
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Please enter a title: ");
            string title = _console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);
            if (foundTitle != null)
            {
                DisplayContent(foundTitle);
            }
            else
            {
                _console.WriteLine("Invalid title. Cound not find any results.");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }
        private void RemoveContentFromList()
        {
            _console.Clear();
            _console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}. {content.Title}");
            }
            int targetContentId = int.Parse(_console.ReadLine());
            int targetIndex = targetContentId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} successfully removed.");
                }
                else
                {
                    _console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                _console.WriteLine("No content has that ID");
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title {content.Title} \n" +
                $"Description {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n" +
                $"Rating {content.MaturityRating}");
        }
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Mr. Right", "Hitman falls in love or something", MaturityRating.R, 5, GenreType.Romance);
            StreamingContent movieTwo = new StreamingContent("Japanese Fraiser", "Fraiser..but from Japan", MaturityRating.PG_13, 5, GenreType.Comedy);
            StreamingContent movieThree = new StreamingContent("Mr. Bond", "007 buy bonds from the US dept. of Treasury", MaturityRating.R, 1, GenreType.Horror);

            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
            _streamingRepo.AddContentToDirectory(movieThree);
        }
    }
}

