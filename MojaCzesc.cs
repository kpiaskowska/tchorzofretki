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

        


        public static String GetFileFromInternet(String adres)
        {

            WebClient webClient = new WebClient();
            string text = "Null";
            try
            {
                webClient.DownloadFile(adres, @"stringfile.txt");
                text = System.IO.File.ReadAllText(@"stringfile.txt");
                File.Delete("stringfile.txt");


            }
            catch (Exception)
            {
                Console.WriteLine("Nie udalo sie otworzyc pliku wejsciowego");
                GetMenu();

            }

            return text;


        }

        //POBIERANIE PLIKU CO WYZEJ- Moje


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
        //LICZENIE LITER -TO WYZEJ

        public static int CountWords(String text)
        {
            string s = text;
            int c = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(s[i]) == true ||
                        char.IsPunctuation(s[i]))
                    {
                        if (!(char.IsLetter(s[i])))
                        {
                            c++;
                        }

                    }
                }
            }
            if (s.Length > 2)
            {
                c++;
            }
            return c;
        }

        // POBIERANIE WYRAZOW TO WYZEJ - moje
        
        public static void ProgramExit()
        {
            string statystyki = @"statystyki.txt";
            string stringfile = @"stringfile.txt";
            if (File.Exists(statystyki))
            {
                File.Delete(statystyki);
            }
            if (File.Exists(stringfile))
            {
                File.Delete(stringfile);
            }
            Console.WriteLine("bye.");
        }
    }
}
//Wyjście - moje