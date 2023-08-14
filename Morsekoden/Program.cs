using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Morsekoden
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Loops until another key than R is pressed when asked
            do
            {
                Console.Clear();
                Console.WriteLine("Enter a text you want to translate to morse code");

                // User input which will be translated
                string userInputText = Console.ReadLine();

                // 2-dimensional array which acts like a translator
                string[,] morseAlphabet = {
                    { 
                        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                        "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "æ", "ø", "å", "0",
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", ",", ":", "?", "'", "-",
                        "/", "(", ")", "\"", "×", "@", " "
                    }, 
                    { 
                        // A-O
                        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                        // P-Å
                        ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".-.-", "---.", ".--.-", 
                        // 0-9
                        "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                        // "."  ","  ":"  "?"  "'"  "-"  "/"  "("  ")"  "\""  "×"  "@"  " "
                        ".-.-.-", "--..--", "---...", "..--..", ".----.", "-....-", "-..-.", "-.--.", "-.--.-", ".-..-.", "-..-", ".--.-.", "/"
                    }

                };

                // Uses the translator and translates every single character in a text
                string morse = "";
                foreach(char s in userInputText.ToLower())
                {

                    // Loops the rows of the 2-dimensional array which gives me every single character
                    for(int i = 0; i < morseAlphabet.GetLength(1); i++)
                    {

                        // Checks if the array contains the character and translates it to morse
                        if(morseAlphabet[0,i].Contains(s))
                        {
                            morse += morseAlphabet[1,i];
                        }
                    }
                    morse += ' ';
                }

                // Writes out the morse code
                Console.Clear();
                Console.WriteLine("You wrote: " + userInputText);
                Console.WriteLine("In morse code: " + morse);
                Console.WriteLine("\nPress R to translate a new morse code, or any other key for closing the program");
            }while (Console.ReadKey(true).Key == ConsoleKey.R);
        }
    }
}
