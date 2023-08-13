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
                string text = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("You wrote: " + text);
                Console.WriteLine("In morse code: " + ToMorse(text.ToLower()));
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
                    case 'a':
                        morse += ".-";
                        break;
                    case 'b':
                        morse += "...-";
                        break;
                    case 'c':
                        morse += "-.-.";
                        break;
                    case 'd':
                        morse += "-..";
                        break;
                    case 'e':
                        morse += ".";
                        break;
                    case 'f':
                        morse += "..-.";
                        break;
                    case 'g':
                        morse += "--.";
                        break;
                    case 'h':
                        morse += "....";
                        break;
                    case 'i':
                        morse += "..";
                        break;
                    case 'j':
                        morse += ".---";
                        break;
                    case 'k':
                        morse += "-.-";
                        break;
                    case 'l':
                        morse += ".-..";
                        break;
                    case 'm':
                        morse += "--";
                        break;
                    case 'n':
                        morse += "-.";
                        break;
                    case 'o':
                        morse += "---";
                        break;
                    case 'p':
                        morse += ".--.";
                        break;
                    case 'q':
                        morse += "--.-";
                        break;
                    case 'r':
                        morse += ".-.";
                        break;
                    case 's':
                        morse += "...";
                        break;
                    case 't':
                        morse += "-";
                        break;
                    case 'u':
                        morse += "..-";
                        break;
                    case 'v':
                        morse += "...-";
                        break;
                    case 'w':
                        morse += ".--";
                        break;
                    case 'x':
                        morse += "-..-";
                        break;
                    case 'y':
                        morse += "-.--";
                        break;
                    case 'z':
                        morse += "--..";
                        break;
                    case 'æ':
                        morse += ".-.-";
                        break;
                    case 'ø':
                        morse += "---.";
                        break;
                    case 'å':
                        morse += ".--.-";
                        break;
                    case '1':
                        morse += ".----";
                        break;
                    case '2':
                        morse += "..---";
                        break;
                    case '3':
                        morse += "...--";
                        break;
                    case '4':
                        morse += "....-";
                        break;
                    case '5':
                        morse += ".....";
                        break;
                    case '6':
                        morse += "-....";
                        break;
                    case '7':
                        morse += "--...";
                        break;
                    case '8':
                        morse += "---..";
                        break;
                    case '9':
                        morse += "----.";
                        break;
                    case '0':
                        morse += "-----";
                        break;
                    case '.':
                        morse += ".-.-.-";
                        break;
                    case ',':
                        morse += "--..--";
                        break;
                    case ':':
                        morse += "---...";
                        break;
                    case '?':
                        morse += "..--..";
                        break;
                    case '\'':
                        morse += ".----.";
                        break;
                    case '-':
                        morse += "-....-";
                        break;
                    case '/':
                        morse += "-..-.";
                        break;
                    case '(':
                        morse += "-.--.";
                        break;
                    case ')':
                        morse += "-.--.-";
                        break;
                    case '\"':
                        morse += ".-..-.";
                        break;
                    case '*':
                        morse += "-..-";
                        break;
                    case '@':
                        morse += ".--.-.";
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
