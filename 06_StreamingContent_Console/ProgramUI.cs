using _06_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContent_Repo _repo = new StreamingContent_Repo();

        public void Run()
        {
            SeedContent(); 
            Menu();
        }

        private void SeedContent()
        {
            StreamingContent futureWar = new StreamingContent("Future War",
                "A war in the future", 10.0, Genre.SciFi, MaturityRating.G);

            StreamingContent blazingSaddles = new StreamingContent("Blazing Saddles", 
                "A sheriff goes to a rural town...", 9.5, Genre.Action, MaturityRating.R);



            StreamingContent theRoom = new StreamingContent("The Room",
            "Everyone betrays Johnny and he's fed up with this world", 10.0, Genre.Documentary, MaturityRating.G);
            _repo.AddContentToDirectory(futureWar);
            _repo.AddContentToDirectory(theRoom);
        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content.\n" + //read
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" + //Create
                    "4. Update existing streaming content\n" + //update
                    "5. Remove streaming content\n" +//delete
                    "6. Exit");

                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        //Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //Get content by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        //Create new streaming content
                        CreateNewContent();
                        break;
                    case "4":
                        //Update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete existing content
                        DeleteContentByTitle();
                        break;
                    case "6":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void ShowAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);

            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void CreateNewContent()
        {
            Console.Clear();

            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("Please enter a title. ");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Please enter a description. ");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Please enter a star rating (1.0 - 10.0) for this content. ");
            newContent.StarRating = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select a genre. ");
            Console.WriteLine("1.Horror");
            Console.WriteLine("2.RomCom");
            Console.WriteLine("3.SciFi");
            Console.WriteLine("4.Action");
            Console.WriteLine("5.Documentary");
            Console.WriteLine("6.Musical");
            Console.WriteLine("7.Drama");
            Console.WriteLine("8.Mystery");

            string genreInput = Console.ReadLine();
            int genreAsInt = int.Parse(genreInput);//parsing
            newContent.Genre = (Genre)genreAsInt;//casting

            bool stopRunning = false;
            while (!stopRunning)
            {

                Console.WriteLine("Select enter a Maturity Rating. ");
                Console.WriteLine("1.G");
                Console.WriteLine("2.PG");
                Console.WriteLine("3.PG_13");
                Console.WriteLine("4.R");
                Console.WriteLine("5.NC_17");

                string maturityInput = Console.ReadLine();
                switch (maturityInput)
                {

                    case "1":
                        newContent.MaturityRating = MaturityRating.G;
                        stopRunning = true;
                        break;
                    case "2":
                        newContent.MaturityRating = MaturityRating.PG;
                        stopRunning = true;
                        break;
                    case "3":
                        newContent.MaturityRating = MaturityRating.PG_13;
                        stopRunning = true;
                        break;
                    case "4":
                        newContent.MaturityRating = MaturityRating.R;
                        stopRunning = true;
                        break;
                    case "5":
                        newContent.MaturityRating = MaturityRating.NC_17;
                        stopRunning = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid rating");
                        stopRunning = false;
                        break;
                }
            }

            bool wasAdded = _repo.AddContentToDirectory(newContent);
            if(wasAdded == true)
            {
                Console.WriteLine("Your content was successfully added");
            } else
            {
                Console.WriteLine("Oops. Your content was not added");
            }
        }
    
        private void UpdateExistingContent()
        {
            Console.Clear();

            //ShowContentByTitle();
            Console.WriteLine("Select the title of the content you'd like to update.");
            string title = Console.ReadLine();
            StreamingContent oldItem = _repo.GetContentByTitle(title);

            if(oldItem == null)
            {
                Console.WriteLine("Content not found, Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("What property would you like to update in it?");
            Console.WriteLine("1. Title");
            Console.WriteLine("2. Description");
            Console.WriteLine("3. Star Rating");
            Console.WriteLine("4. Genre");
            Console.WriteLine("5. Maturity Rating");

            string updateInput = Console.ReadLine();
            switch (updateInput)
            {
                case "1":
                    Console.WriteLine("Please enter the new title");
                    oldItem.Title = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Please enter the new description");
                    oldItem.Description = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Please enter the new Star Rating");
                    oldItem.StarRating = Convert.ToDouble(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("Please enter the new Genre");

                    Console.WriteLine("Select a genre. ");
                    Console.WriteLine("1.Horror");
                    Console.WriteLine("2.RomCom");
                    Console.WriteLine("3.SciFi");
                    Console.WriteLine("4.Action");
                    Console.WriteLine("5.Documentary");
                    Console.WriteLine("6.Musical");
                    Console.WriteLine("7.Drama");
                    Console.WriteLine("8.Mystery");

                    string genreThingy = Console.ReadLine();
                    int genreThing = int.Parse(genreThingy);//parsing
                    oldItem.Genre = (Genre)genreThing;//casting

                    break;
                //case "5":
                //    Console.WriteLine("Please enter the new Maturity Rating");
                //    oldItem.MaturityRating = Console.ReadLine();
                //    break;
                default:
                    Console.WriteLine("Please enter a value.");
                    break;

            }
        }

        private void ShowContentByTitle()
        {
            Console.Clear();

            Console.WriteLine("Enter the title of the content you'd like to see.");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);
            if(content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("That title doesn't exist. Try again.");
            }
                Console.ReadKey();
        }

        //method that prompts user for which streamingContent object they want to delete
        //remove it from the _contentDirectory.

        //Bonus: Display all the options fro them to select from
                

        private void DeleteContentByTitle()
        {
            Console.Clear();

            ShowAllContent();
            Console.WriteLine("What would you like to delete?");
            string title = Console.ReadLine();
            StreamingContent contentToDelete = _repo.GetContentByTitle(title);
            bool wasDeleted = _repo.DeleteExistingContent(contentToDelete);
            if (wasDeleted)
            {
                Console.WriteLine("This content was deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
            }
        }

        private void DisplayContent(StreamingContent content) //helper method
        {
            Console.WriteLine($"Title: {content.Title}");
            Console.WriteLine($"Description: {content.Description}");
            Console.WriteLine($"Star Rating: {content.StarRating}");
            Console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            Console.WriteLine($"Genre: {content.Genre}");
            Console.WriteLine($"Is it family friendly: {content.IsFamilyFriendly}");
        }
    }
}
