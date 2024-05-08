using System;

namespace FileReader.m
{
    public static class UserInterface
    {
        public static void PrintHelpMenu()
        {
            string logo = @"
 _   _          _         
| | | |   ___  | |  _ __  
| |_| |  / _ \ | | | '_ \ 
|  _  | |  __/ | | | |_) |
|_| |_|  \___| |_| | .__/ 
                   |_|    
";
            Console.WriteLine(logo);
            Console.WriteLine("Write \"add[space]some text\" to add a new record.");
            Console.WriteLine("Write \"remove[space]n\" to delete record.");
            Console.WriteLine("Write \"removeall\" to delete all from saved records.");
            Console.WriteLine("Write \"edit[space]n\" to overwrite record.");
            Console.WriteLine("Write \"p\" to print all records.");
            Console.WriteLine("Write \"c\" to clear console text.");
            Console.WriteLine("Write \"exit\" to exit app.");
            Console.WriteLine("n == number of record.");
        }

        public static void PrintHeading()
        {
            Console.WriteLine("For help write \"h\".");
            //Console.WriteLine("----------------------------------");
            Console.WriteLine("────────────────────────────────────");

        }
        public static void PrintErrorMsg(string input)
        {
            Console.WriteLine($"{input} is not valid!");
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
        }
    }
}
