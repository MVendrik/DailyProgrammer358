using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DailyProgrammer358
{
    class Program
    // https://www.reddit.com/r/dailyprogrammer/comments/8eger3/20180423_challenge_358_easy_decipher_the_seven/ 
    // This solution reads ciphertext, a 7-segment display, from a file and converts the ciphertext to the numbers they represent. 
    {
        static void Main(string[] args)
        {
           
            string[] FileOutput = File.ReadLines(@"C:\Users\Marieke\Documents\input_test.txt").ToArray();
            // print the numbers in this file.
            foreach (var item in FileOutput)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            string EndResult = "";

            for (int i = 0; i < 9; i++)
            {
                string Ciphers = "";
                for (int j = 0; j < FileOutput.Length; j++)
                {
                    Ciphers += FileOutput[j].Substring(0, 3);
                    FileOutput[j] = FileOutput[j].Remove(0, 3);
                }

                EndResult += DecipherNumbers(Ciphers);

            }

            Console.WriteLine(EndResult);

            Console.ReadLine();
            
        }

        public static string DecipherNumbers(string Ciphers)
        {
            if (Ciphers == "     |  |")
                return "1";
            else if (Ciphers == " _  _||_ ")
                return "2";
            else if (Ciphers == " _  _| _|")
                return "3";
            else if (Ciphers == "   |_|  |")
                return "4";
            else if (Ciphers == " _ |_  _|")
                return "5";
            else if (Ciphers == " _ |_ |_|")
                return "6";
            else if (Ciphers == " _   |  |")
                return "7";
            else if (Ciphers == " _ |_||_|")
                return "8";
            else if (Ciphers == " _ |_| _|")
                return "9";
            else
                return "0";

        }
    }
}
