using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class Program
    {

        public static void Main(string[] args)
        {
            int Program_run = 1;
            GetMenu();
            int Menu_option = Convert.ToInt32(Console.ReadLine());
            string Text = "Null";
            string adres = "Null";
            while (Program_run == 1)
            {
                switch (Menu_option)
                {
                    case 1:
                        Console.WriteLine("Get file from internet? T/N");
                        String odp = Console.ReadLine();
                        if (odp == "T" || odp == "t")
                        {
                            Console.WriteLine("Give a adress");
                            adres = Console.ReadLine();
                            Text = GetFileFromInternet(adres);
                        }
                        else
                        {
                            Console.WriteLine("Give adress from local stoarge:");
                            adres = Console.ReadLine();
                            Text = GetFileFromInternet(adres);
                        }
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        if (Text != "Null")
                        {
                            string SumOfLetters = CountLetters(Text);
                            Console.WriteLine(SumOfLetters);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the file does not exist. \n \n Choose option no. 1 and try again \n\n");
                        }
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        if (Text != "Null")
                        {
                            int SumOfWords = CountWords(Text);
                            Console.WriteLine("Number of words in the file: " + SumOfWords);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the file does not exist. \n \n Choose option no. 1 and try again \n\n");
                        }
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        if (Text != "Null")
                        {
                            int SumOfPunctationMarks = CountpunctuationmarksLetters(Text);
                            Console.WriteLine("Number of Puntactionsmark in the file: " + SumOfPunctationMarks);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the file does not exist. \n \n Choose option no. 1 and try again \n\n");
                        }
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        if (Text != "Null")
                        {
                            int SumOfSentences = CountSentences(Text);
                            Console.WriteLine("Number of Sentences in the file: " + SumOfSentences);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the file does not exist. \n \n Choose option no. 1 and try again \n\n");
                        }
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 6:
                        if (Text != "Null")
                        {
                            GenerateRaport(Text);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the file does not exist. \n \n Choose option no. 1 and try again \n\n");
                        }
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 7:
                        SaveStatistic(adres);
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You must select an option from the menu \n");
                        GetMenu();
                        Menu_option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Program_run = 0;
                        ProgramExit();
                        break;
                }

            }
        }
        public static void GetMenu()
        {
            Console.WriteLine("   Menu \n==========\n");
            Console.WriteLine("1 - Chose input file");
            Console.WriteLine("2 - Count letters");
            Console.WriteLine("3 - Count words");
            Console.WriteLine("4 - Count punctuation marks");
            Console.WriteLine("5 - Count sentences");
            Console.WriteLine("6 -  Generate report about count of every letter in the file");
            Console.WriteLine("7 - Save statistics to the file");
            Console.WriteLine("8 - Exit");
        }
        

        public static string CountLetters(String text)
        {
            int CountLetters = text.Count(char.IsLetter);


            int vowels = 0;
            int consonant = 0;
            int space = 0;

            Console.WriteLine("Enter a Sentence or a Character");
            string v = text;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == 'a' || v[i] == 'e' || v[i] == 'i' || v[i] == 'o' || v[i] == 'u' || v[i] == 'A' || v[i] == 'E' || v[i] == 'I' || v[i] == 'O' || v[i] == 'U')
                {
                    vowels++;
                }

                else if (char.IsWhiteSpace(v[i]))

                {
                    space++;
                }

                else
                {
                    consonant++;
                }
            }

            Console.WriteLine("Your total number of vowels is: {0}", vowels);
            Console.WriteLine("Your total number of constant is: {0}", consonant);
            Console.WriteLine("Your total number of space is: {0}", space);
            string count = "Your total number of vowels is: " + vowels + " Your total number of constant is: " + consonant + " Your total number of space is: " + space;
            return count;

        }

        
       
        
        
       
       
    }
}