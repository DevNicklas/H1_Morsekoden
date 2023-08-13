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
                string text = Console.ReadLine().ToUpper();

                Console.Clear();
                Console.WriteLine("You wrote: " + text);
                Console.WriteLine("In morse code: " + ToMorse(text));
                Console.WriteLine("\nPress R to translate a new morse code, or any other key for closing the program");
            }while (Console.ReadKey(true).Key == ConsoleKey.R);
        }

        /// <summary>
        /// Translate to morse code
        /// </summary>
        /// <param name="text">text to translate</param>
        /// <returns><paramref name="text"/> translated to morse</returns>
        static string ToMorse(string text)
        {
            string morse = "";

            // Loops the entire text, character after character and translates it to morse
            foreach (char character in text)
            {
                switch (character)
                {
                    case 'A':
                        morse += ".-";
                        break;
                    case 'B':
                        morse += "...-";
                        break;
                    case 'C':
                        morse += "-.-.";
                        break;
                    case 'D':
                        morse += "-..";
                        break;
                    case 'E':
                        morse += ".";
                        break;
                    case 'F':
                        morse += "..-.";
                        break;
                    case 'G':
                        morse += "--.";
                        break;
                    case 'H':
                        morse += "....";
                        break;
                    case 'I':
                        morse += "..";
                        break;
                    case 'J':
                        morse += ".---";
                        break;
                    case 'K':
                        morse += "-.-";
                        break;
                    case 'L':
                        morse += ".-..";
                        break;
                    case 'M':
                        morse += "--";
                        break;
                    case 'N':
                        morse += "-.";
                        break;
                    case 'O':
                        morse += "---";
                        break;
                    case 'P':
                        morse += ".--.";
                        break;
                    case 'Q':
                        morse += "--.-";
                        break;
                    case 'R':
                        morse += ".-.";
                        break;
                    case 'S':
                        morse += "...";
                        break;
                    case 'T':
                        morse += "-";
                        break;
                    case 'U':
                        morse += "..-";
                        break;
                    case 'V':
                        morse += "...-";
                        break;
                    case 'W':
                        morse += ".--";
                        break;
                    case 'X':
                        morse += "-..-";
                        break;
                    case 'Y':
                        morse += "-.--";
                        break;
                    case 'Z':
                        morse += "--..";
                        break;
                    case 'Æ':
                        morse += ".-.-";
                        break;
                    case 'Ø':
                        morse += "---.";
                        break;
                    case 'Å':
                        morse += ".--.-";
                        break;
                    case ' ':
                        morse += "/";
                        break;
                }
                morse += " ";
            }
            return morse;
        }
    }
}
