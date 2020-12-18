using System;
using System.Globalization;

namespace Game
{
     static class Madlib
    {
        //declare variables
        static string[] Words = new string[] { "creature", "luminous", "ghastly", "spectral", "countryman", "farrier", "farmer", "dreadful", "apparition", "hound" };
        static string[] Prompts = new string[] { "noun", "adjective", "adjective", "adjective", "occupation", "occupation", "occupation", "adjective", "noun", "noun" };
        static string Story;
        static string GameTitle;

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //write header and instructions
            //Set window bar title
            Console.Title = "ASCII Art";
            string title = @"
      _                             __  __           _   _ _         
     | |                           |  \/  |         | | (_) |        
     | | __ _ ___  ___  _ __  ___  | \  / | __ _  __| | |_| |__  ___ 
 _   | |/ _` / __|/ _ \| '_ \/ __| | |\/| |/ _` |/ _` | | | '_ \/ __|
| |__| | (_| \__ \ (_) | | | \__ \ | |  | | (_| | (_| | | | |_) \__ \
 \____/ \__,_|___/\___/|_| |_|___/ |_|  |_|\__,_|\__,_|_|_|_.__/|___/
                                                                     
                                                                 ";

            Console.WriteLine(title);
            //Console.Read();
        }

        static void GetWords()
        {
            //ask player to enter words
            for (int i = 0; i < Words.Length; i++)
            {
                Console.Write("Please enter a/an " + Prompts[i] + ": ");
                Words[i] = Console.ReadLine();
            }

            //clear the console window
            Console.Clear();
        }

        static void WriteStory()
        {
            
            //Concatenate strings to make a title
            GameTitle = "The " + Words[1] + " " + Words[2] + " " + Words[0];

            //So we can capitalize the words in our title
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            //Write the title to the console window
            Console.WriteLine(GameTitle);

            //change the title of the application window
            Console.Title = GameTitle;

            //write out story
            Story = "They all agreed that it was a huge {0}, {1}, {2}, and {3}.\nI have cross-examined these men, one of them a hard-headed {4},\none a {5}, and one a moorland {6}, who all tell the same story\nof this {7} {8}, exactly corresponding to the {9} of the legend.";
            Console.WriteLine(Story, Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6], Words[7], Words[8], Words[9]);


        }

        static void End()
        {
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }

        //Method with statements
    }
    class Program
    {
        static void Main()
        {
            Madlib.Run();
        }
    }
}
