﻿using FileReader.Core.Interface;
using FileReader.m;
using FileReader.Models;
using System;

namespace FileReader.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            UserInterface.PrintLogo();
            UserInterface.PrintHeading();
            bool runApp = true;
            while (runApp)
            {
                TextFile textFile = new();

                UserInterface.ChangeColorToGreen();
                string[] input = Console.ReadLine().Split(new[] { " " }, 2, StringSplitOptions.RemoveEmptyEntries);
                Console.ResetColor();

                if (input.Length > 1 && input != null)
                {
                    switch (input[0].ToLower())
                    {
                        case "add": textFile.WriteToFile(input[1]); break;
                        case "remove": textFile.RemoveLine(input[1]); break;
                        case "edit": textFile.EditLine(input[1]); break;
                        default: UserInterface.PrintErrorMsg(input[0]); break;
                    }
                }
                else if (input.Length == 1 && input != null)
                {
                    switch (input[0].ToLower())
                    {
                        case "p": Console.WriteLine(textFile.ReadFromFile()); break;
                        case "c": Console.Clear(); break;
                        case "h": UserInterface.PrintHelpMenu(); break;
                        case "removeall": textFile.RemoveAll(); break;
                        case "exit": runApp = false; break;
                        default: UserInterface.PrintErrorMsg(input[0]); break;
                    }
                }
            }
        }
    }
}
