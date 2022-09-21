using System;
using System.Collections.Generic;
using System.Linq;

namespace SO_Task2
{
    public class CorrectStrings
    {
        public static string ReadInput()
        {
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string inputLine = ReadInput();
            IsStringCorrect(inputLine);

        }

        public static string IsStringCorrect(string inputLine)
        {
            string trimmed = inputLine.Trim();

            Dictionary<char, int> myList = KeyValuePairs(trimmed);

            for (int i = 0; i < trimmed.Length; i++)
            {
                if (myList.ContainsKey(trimmed[i]))
                {
                    myList[trimmed[i]]++;
                }
            }

            if (myList.Values.Distinct().Count() == 1)
            {
                Console.WriteLine("Correct string!");
                return "Correct string!";
            }
            else if (myList.Values.Distinct().Count() == 2)
            {
                int validator = myList.Values.Distinct().OrderBy(x => x).First();
                if (validator == 1 && myList.Select(x => x.Value == 1).ToList().Count == 1)
                {
                    Console.WriteLine("Correct string!");
                    return "Correct string!";
                }
                else if (myList.Values.Distinct().OrderByDescending(x => x).First() == (myList.Values.Distinct().OrderByDescending(x => x).Last() + 1))
                {
                    Console.WriteLine("Correct string!");
                    return "Correct string!";
                }
                else
                {
                    Console.WriteLine("Wrong string!");
                    return "Wrong string!";
                }
            }

            Console.WriteLine("Wrong string!");
            return "Wrong string!";

        }

        public static Dictionary<char, int> KeyValuePairs(string word)
        {
            string nonDuplicates = string.Join("", word.ToCharArray().Distinct());

            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (var letter in nonDuplicates)
            {
                result[letter] = 0;
            }

            return result;
        }
    }
}
