using _06_StreamingContent_Repository;
using _06_StreamingContent_Repository.Content;
using _09_StreamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor
{
    public class ProgramUI
    {
        //Fields:
        private StreamingContent_Repo _repo = new StreamingContent_Repo();

        //dependency injection - an IConsole object must be passed in when this is created
        private IConsole _console;
        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        //Everything this class does
        public void SayHello()
        {
            _console.WriteLine("What is your name?");
            string name = _console.ReadLine();
            _console.WriteLine($"Hey, {name}, how are you doing?");
            string reply = _console.ReadLine();
            _console.WriteLine(reply);
            _console.ReadKey();
        }

        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void SeedContent()
        {
            Movie futureWar = new Movie("Future War",
                "A war in the future", 10.0, Genre.SciFi, MaturityRating.G, 90.0);

            Movie blazingSaddles = new Movie("Blazing Saddles",
                "A sheriff goes to a rural town...", 9.5, Genre.Action, MaturityRating.R, 136.4);

            Movie theRoom = new Movie("The Room",
            "Everyone betrays Johnny and he's fed up with this world", 10.0, Genre.Documentary, MaturityRating.G, 139.0);

            Show burnNotice = new Show();
            burnNotice.Title = "Burn Notice";
            burnNotice.MaturityRating = MaturityRating.PG_13;
            burnNotice.Description = "A spy recently disavowed by the U.S. government uses his special ops training to help others in trouble.";
            burnNotice.Genre = Genre.Action;

            List<Episode> episodes = new List<Episode>();
            //Make an episode and then add it
            Episode episode = new Episode();
            episode.Title = "Tikka to Ride";
            episodes.Add(episode);
            //Make and add an episode on the same line
            episodes.Add(new Episode("Break Out Games", 45, 7));
            episodes.Add(new Episode("Lesser Evil", 50, 7));

            burnNotice.Episodes = episodes;


            _repo.AddContentToDirectory(futureWar);
            _repo.AddContentToDirectory(theRoom);
            _repo.AddContentToDirectory(burnNotice);
        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();

                _console.WriteLine("Enter the number of the option you'd like to select:\n" +
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
                        //ShowContentByTitle();
                        break;
                    case "3":
                        //Create new streaming content
                        //CreateNewContent();
                        break;
                    case "4":
                        //Update existing content
                        //UpdateExistingContent();
                        break;
                    case "5":
                        //Delete existing content
                        //DeleteContentByTitle();
                        break;
                    case "6":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please choose a valid option");
                        _console.ReadKey();
                        break;
                }
            }
        }

        public void ShowAllContent()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _repo.GetContents();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }
        private void DisplayContent(StreamingContent content) //helper method
        {
            if(content.GetType().Name == "Movie")
            {
                _console.WriteLine("========= Movie =========");
                //Movie movie = (Movie)content;
                //_console.WriteLine($"Run Time: {movie.RunTime}");
                _console.WriteLine( ( (Movie) content ).RunTime ); //casting content as a movie and then getting movie runtime
            }
            if (content.GetType().Name == "Show")
            {
                _console.WriteLine("========= Show =========");
                //Show show = (Show)content;
                //_console.WriteLine($"Episodes: {show.EpisodeCount}");
                _console.WriteLine(((Show)content).EpisodeCount); //casting content as a movie and then getting movie runtime
            }
            _console.WriteLine($"Title: {content.Title}");
            _console.WriteLine($"Description: {content.Description}");
            _console.WriteLine($"Star Rating: {content.StarRating}");
            _console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            _console.WriteLine($"Genre: {content.Genre}");
            _console.WriteLine($"Is it family friendly: {content.IsFamilyFriendly}");
        }
    }
}
