/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP-003
 * Purpose: Replicate the output for the assignment 
 */

using System.Diagnostics.Metrics;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Array - CharacterCounter");
        }

        /// <summary>
        /// Section Separator method
        /// </summary>
        /// <param name="title">String input for title name</param>
        static void PrintSeparator(string title)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{title} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }


        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                characterInput = char.ToLower(characterInput);
                word = word.ToLower();

                if (word[i] == characterInput)
                    count ++;
            }
            return count;
        }


        static bool IsPalindrome(string word) 
        {
            
        }
    }
}