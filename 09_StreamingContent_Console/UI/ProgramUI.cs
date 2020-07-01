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
    class ProgramUI//remember public 
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository(); //this is important bc when we run this program this creates a streaming repo and pursistes for the length of the program. 
        public void Run()//how we enter this class
        {
            RunMenu();
        }

        private void RunMenu()//start menu, we;re trying to create a path for the user. Control what they see
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" + // '\n' reps a new line 
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by tite \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit"); //this follows crud 
                string userInput = Console.ReadLine();
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
                        Console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent(); //ref to 07_
            // title
            Console.WriteLine("Please enter the title of the content: ");
            content.Title = Console.ReadLine(); //readline always returns a string 

            //decription
            Console.WriteLine("Please enter the description of the content: ");
            content.Description = Console.ReadLine();

            //Maturity rating
            Console.WriteLine("Please Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG-13 \n" +
                "4) R \n" +
                "5) NC-17 \n" +
                "6) TV-MA");
            string maturityString = Console.ReadLine();
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
            Console.WriteLine("Please enter the star rating (1-5): ");
            content.StarRating = int.Parse(Console.ReadLine()); //parse is similar to casting turns string to int 

            // type of genre 
            Console.WriteLine("Please enter the Maturity Rating of the content: "); //remember enum 
            Console.WriteLine("Select a Genre: \n" +
                "1: Horror \n" +
                "2: Sci-Fi \n" +
                "3: Drama \n" +
                "4: Action \n" +
                "5: Comedy \n" +
                "6: Anime \n" +
                "7: Documentary \n" +
                "8: Thriller \n" +
                "9: Romance");
            string genreInput = Console.ReadLine(); //this works in leiu of the switch case 
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID; //<--casting taking an int and casting to an enum 
            _streamingRepo.AddContentToDirectory(content);//now this a part of the content directory 
        }
        private void ShowAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();

            foreach (StreamingContent contentVariable in listOfContent) //for each loop, what is collection made out of 
            {
                DisplayContent(contentVariable);
                //Console.WriteLine($"{contentVariable.Title} {contentVariable.Description}");//going thru every single item
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Please enter a title: ");
            string title = Console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);
            if (foundTitle != null)
            {
                DisplayContent(foundTitle);
            }
            else
            {
                Console.WriteLine("Invalid title. Cound not find any results.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void RemoveContentFromList()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {count.Title}");
            }
            int targetContentId = int.Parse(Console.ReadLine());
            int targetIndex = targetContentId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} successfully removed.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title {content.Title} \n" +
                $"Description {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n" +
                $"Rating {content.MaturityRating}");
        }
    }
}

