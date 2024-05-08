using System;

namespace FileReader.m
{
    public static class UserInterface
    {
        public static void PrintHelpMenu()
        {
            Console.WriteLine("Write \"add[space]some text\" to add a new line.");
            Console.WriteLine("Write \"remove[space]n\" to delete line.");
            Console.WriteLine("Write \"removeall\" to delete all from text file.");
            Console.WriteLine("Write \"edit[space]n\" to edit line.");
            Console.WriteLine("Write \"print\" to print all line.");
            Console.WriteLine("Write \"clear\" to clear console text.");
            Console.WriteLine("Write \"exit\" to exit app.");
            Console.WriteLine("n == number of line.");
        }

        public static void PrintHeading()
        {
            Console.WriteLine("For help write \"help\".");
            Console.WriteLine("----------------------------------");
        }
        public static void PrintErrorMsg(string input)
        {
            Console.WriteLine($"{input} is not valid command!");
        }

        public static void ChangeColorToGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void PrintLogo()
        {
            string logo = @" 
 _   _           _                
| \ | |         | |               
|  \| |   ___   | |_    ___   ___ 
| . ` |  / _ \  | __|  / _ \ / __|
| |\  | | (_) | | |_  |  __/ \__ \
|_| \_|  \___/   \__|  \___| |___/
                                                
                               ";
            Console.WriteLine(logo);
            Console.WriteLine();
        }
    }
}
