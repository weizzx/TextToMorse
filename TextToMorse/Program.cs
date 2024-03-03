using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextToMorse
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            /* 
             * TEXT TO MORSE - Created by weizzx
               Frequency = 420 (default);
               Dash = 999ms;
               Dot = 333ms;
               Space = 999ms;
            */
            Console.Title = "TextToMorse";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string input;
            int freq = 420;
            input = Console.ReadLine();
            int inputLength = input.Length;

            for (int i = 0; i < inputLength; i++)
            {
                switch (input[i])
                {
                    case 'a': case 'A': beepA(freq); break;
                    case 'b': case 'B': beepB(freq); break;
                    case 'c': case 'C': beepC(freq); break;
                    case 'd': case 'D': beepD(freq); break;
                    case 'e': case 'E': beepE(freq); break;
                    case 'f': case 'F': beepF(freq); break;
                    case 'g': case 'G': beepG(freq); break;
                    case 'h': case 'H': beepH(freq); break;
                    case 'i': case 'I': beepI(freq); break;
                    case 'j': case 'J': beepJ(freq); break;
                    case 'k': case 'K': beepK(freq); break;
                    case 'l': case 'L': beepL(freq); break;
                    case 'm': case 'M': beepM(freq); break;
                    case 'n': case 'N': beepN(freq); break;
                    case 'o': case 'O': beepO(freq); break;
                    case 'p': case 'P': beepP(freq); break;
                    case 'q': case 'Q': beepQ(freq); break;
                    case 'r': case 'R': beepR(freq); break;
                    case 's': case 'S': beepS(freq); break;
                    case 't': case 'T': beepT(freq); break;
                    case 'u': case 'U': beepU(freq); break;
                    case 'v': case 'V': beepV(freq); break;
                    case 'w': case 'W': beepW(freq); break;
                    case 'x': case 'X': beepX(freq); break;
                    case 'y': case 'Y': beepY(freq); break;
                    case 'z': case 'Z': beepZ(freq); break;



                    default:
                            Console.Write("  ");
                            Thread.Sleep(999);
                            break;
                }
            }
                Console.ReadLine();
                Console.Clear();
        }

        static void beepA(int freq) 
        {
            Console.Write(".- ");
            Dot(freq);
            Dash(freq);
        }
        static void beepB(int freq)
        {
            Console.Write("-... ");
            Dash(freq);
            Dot(freq);
            Dot(freq);
            Dot(freq);
        }
        static void beepC(int freq)
        {
            Console.Write("-.-. ");
            Dash(freq);
            Dot(freq);
            Dash(freq);
            Dot(freq);
        }
        static void beepD(int freq)
        {
            Console.Write("-.. ");
            Dash(freq);
            Dot(freq);
            Dot(freq);
        }
        static void beepE(int freq)
        {
            Console.Write(". ");
            Dot(freq);
        }
        static void beepF(int freq)
        {
            Console.Write("..-. ");
            Dot(freq);
            Dot(freq);
            Dash(freq);
            Dot(freq);
        }
        static void beepG(int freq)
        {
            Console.Write("--. ");
            Dash(freq);
            Dash(freq);
            Dot(freq);
        }
        static void beepH(int freq)
        {
            Console.Write(".... ");
            Dot(freq);
            Dot(freq);  
            Dot(freq);
            Dot(freq);
        }
        static void beepI(int freq)
        {
            Console.Write(".. ");
            Dot(freq);
            Dot(freq);
        }
        static void beepJ(int freq)
        {
            Console.Write(".--- ");
            Dot(freq);
            Dash(freq);
            Dash(freq);
            Dash(freq);
        }
        static void beepK(int freq)
        {
            Console.Write("-.- ");
            Dash(freq);
            Dot(freq);
            Dash(freq);
        }
        static void beepL(int freq)
        {
            Console.Write(".-.. ");
            Dot(freq);
            Dash(freq);
            Dot(freq);
            Dot(freq);
        }
        static void beepM(int freq)
        {
            Console.Write("-- ");
            Dash(freq);
            Dash(freq);
        }
        static void beepN(int freq)
        {
            Console.Write("-. ");
            Dash(freq);
            Dot(freq);
        }
        static void beepO(int freq)
        {
            Console.Write("--- ");
            Dash(freq);
            Dash(freq);
            Dash(freq);
        }
        static void beepP(int freq)
        {
            Console.Write(".--. ");
            Dot(freq);
            Dash(freq);
            Dash(freq);
            Dot(freq);
        }
        static void beepQ(int freq)
        {
            Console.Write("--.- ");
            Dash(freq);
            Dash(freq);
            Dot(freq);
            Dash(freq);
        }
        static void beepR(int freq)
        {
            Console.Write(".-. ");
            Dot(freq);
            Dash(freq);
            Dot(freq);
        }
        static void beepS(int freq)
        {
            Console.Write("... ");
            Dot(freq);
            Dot(freq);
            Dot(freq);
        }
        static void beepT(int freq)
        {
            Console.Write("- ");
            Dash(freq);
        }
        static void beepU(int freq)
        {
            Console.Write("..- ");
            Dot(freq);
            Dot(freq);
            Dash(freq);
        }
        static void beepV(int freq)
        {
            Console.Write("...- ");
            Dot(freq);
            Dot(freq);
            Dot(freq);
            Dash(freq);
        }
        static void beepW(int freq)
        {
            Console.Write(".-- ");
            Dot(freq);
            Dash(freq);
            Dash(freq);
        }
        static void beepX(int freq)
        {
            Console.Write("-..-");
            Dash(freq);
            Dot(freq);
            Dot(freq);
            Dash(freq);
        }
        static void beepY(int freq)
        {
            Console.Write("-.-- ");
            Dash(freq);
            Dot(freq);
            Dash(freq);
            Dash(freq);
        }
        static void beepZ(int freq)
        {
            Console.Write("--..");
            Dash(freq);
            Dash(freq);
            Dot(freq);
            Dot(freq);
        }

        static void Dot(int freq)
        {
            Console.Beep(freq, 333);
        }
        static void Dash(int freq)
        {
            Console.Beep(freq, 999);
        }
    }
}
