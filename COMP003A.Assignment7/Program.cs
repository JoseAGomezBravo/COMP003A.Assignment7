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

            Console.Write("Please enter a letter \n");
            char Usercharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Please enter a word \n");
            string UserWord = Console.ReadLine();

            int Wordcount = CharacterCounter(Usercharacter, UserWord);

            Console.WriteLine($"There are {Wordcount} letter {Usercharacter} in the word {UserWord}");


            PrintSeparator("Array - IsPalindrome");

            Console.WriteLine("\n");
            Console.Write("Please enter a word to check if it is a palindrome \n");
            string PalindromeWord = Console.ReadLine();

            bool TruePalindrome = IsPalindrome(PalindromeWord);

            if (TruePalindrome) // if the word is palindrome then its true, if not its false
            {
                Console.WriteLine($"Is the word {PalindromeWord} palindrome: True");
            }
            else
            {
                Console.WriteLine($"Is the word {PalindromeWord} palindrome: False");
            }


            PrintSeparator("List - Add");


            List<string> names = new List<string>();

            char userInput = default;

            do // requests user input (name) until the character chosen is (e)
            {
                Console.WriteLine("\n");

                Console.Write("Please enter a name \n");
                string name = Console.ReadLine();

                names.Add(name); // adds the name to the list

                Console.Write("Press any key to add more or (e) to exit \n");
                userInput = Console.ReadKey().KeyChar; // stores character input
                Console.WriteLine();

            } while (userInput != 'e'); // stops the loop if input is (e)


            PrintSeparator("List - Traversal");

            TraverseList(names); //calls for list of names

            PrintSeparator("List - Reverse Traversal");

            TraverseListReverse(names); // calls for list list of names but in reverse
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

        /// <summary>
        /// Counts the amount of times user character appears within user word
        /// </summary>
        /// <param name="characterInput">Input char character</param>
        /// <param name="word">Input string word</param>
        /// <returns>amount of appearances (count)</returns>
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

        /// <summary>
        /// First it makes all the characters within the word lower case, then it reverses the word and stores it within a string, there allowing it to compare both
        /// </summary>
        /// <param name="word">User input string</param>
        /// <returns>True or false, if the word matches its reversed version</returns>
        static bool IsPalindrome(string word) 
        {
            string lowercaseWord = word.ToLower();

            string reversedWord = "";

            for (int i = lowercaseWord.Length - 1; i >= 0; i--)
            {
                reversedWord += lowercaseWord[i];
            }

            if (reversedWord.ToLower()== word.ToLower()) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Outputs the list 
        /// </summary>
        /// <param name="list">Input list name</param>
        static void TraverseList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// Outputs the list in reverse
        /// </summary>
        /// <param name="list">Input list name</param>
        static void TraverseListReverse(List<string> list) 
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }




    }
}