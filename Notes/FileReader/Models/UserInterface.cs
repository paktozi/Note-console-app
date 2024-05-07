﻿using System;

namespace FileReader.m
{
    public static class UserInterface
    {
        public static void PrintHelpMenu()
        {
            Console.WriteLine("Write \"add:\" to add a new line.");
            Console.WriteLine("Write \"remove:n\" to delete line.");
            Console.WriteLine("Write \"removeall\" to delete all from text file.");
            Console.WriteLine("Write \"edit:n\" to edit line.");
            Console.WriteLine("Write \"print\" to print all line.");
            Console.WriteLine("Write \"clear\" to clear console text.");
            Console.WriteLine("Write \"exit\" to exit app.");
            Console.WriteLine("n == number of line.");
        }

        public static void PrintHeading()
        {
            Console.WriteLine("For help write \"help\".");
            Console.WriteLine("#######################");
        }
        public static void PrintErrorMsg(string input)
        {
            Console.WriteLine($"{input} is nod valid command!");
        }

        public static void ChangeColorToGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}