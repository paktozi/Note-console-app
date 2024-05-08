using FileReader.m;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader.Models;

public class TextFile
{
    private string path = "../../../Resources/text.txt";
    private List<string> list;

    public TextFile()
    {
        list = new(File.ReadLines(path));
    }

    public void WriteToFile(string word)
    {
        File.WriteAllLines(path, list.ToArray());
        string count = (list.Count + 1).ToString();
        using (StreamWriter writer = new(path, true))
        {
            if (word != null && word != string.Empty)
            {
                writer.WriteLine(count + "." + word);
                Console.WriteLine($"Line {count} added!");
                list.Add(count + "." + word);
            }
        }
        PrintAll();
    }


    public string ReadFromFile()
    {
        Console.WriteLine("───────────────────────");
        using (StreamReader reader = new(path))
        {
            return (list.Count == 0) ? "There are no records to print." : reader.ReadToEnd() + "───────────────────────";
        }
    }


    public void RemoveLine(string number)
    {
        number = number.Trim();
        if (Validator.IsValidInteger(number))
        {
            int num = int.Parse(number);

            if (!Validator.IsNotValidNumber(num, list.Count))
            {
                list.RemoveAll(l => l.StartsWith(number));
                File.WriteAllLines(path, list.ToArray());
                Console.WriteLine($"Line {number} removed!");

                for (int i = num - 1; i < list.Count; i++)    //    rewrite number of line
                {
                    string word = list[i];
                    char[] wordToChar = word.ToCharArray();
                    int n = i + 1;
                    char c = (char)(n + '0');
                    wordToChar[0] = c;
                    list[i] = new string(wordToChar);
                }
            }
            File.WriteAllLines(path, list.ToArray());//update text.txt with list
            PrintAll();
        }
        else
        {
            UserInterface.PrintErrorMsg(number);
        }
    }

    public void RemoveAll()
    {
        list.Clear();
        File.WriteAllLines(path, list.ToArray());
        Console.WriteLine("All records are cleared!");
    }

    public void EditLine(string number)
    {
        number = number.Trim();
        if (Validator.IsValidInteger(number))
        {
            int num = int.Parse(number);
            if (!Validator.IsNotValidNumber(num, list.Count))
            {
                int index = list.FindIndex(x => x.StartsWith(number));
                Console.WriteLine(list[index]);
                Console.Write("Enter new record:  ");
                string newWord = Console.ReadLine();
                list[index] = $"{number}.{newWord}";
                File.WriteAllLines(path, list.ToArray());
                Console.WriteLine($"Line {number} edited successful!");
                PrintAll();
            }
        }
        else
        {
            UserInterface.PrintErrorMsg(number);
        }
    }

    private void PrintAll()
    {
        Console.WriteLine();
        list.ForEach(x => Console.WriteLine(x));
        Console.ResetColor();
        Console.WriteLine();
    }
}
