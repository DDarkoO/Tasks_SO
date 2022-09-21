using System;

namespace SO_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Your job is to find the smallest and the largest number that can be obtained by switching two digits from a given number.Write a function that takes a number and returns the min and max number in the following format "Min: 551 Max: 155".The number should not start with zero.
            string userInput = Console.ReadLine();
            MaxMinNumber(int.Parse(userInput));
        }

        public static string MaxMinNumber(int number)
        {
            if (number.ToString().StartsWith("0")) return "The input number must not start with 0, please try again";

            int max = 0;
            int min = 0;

            string digits = number.ToString();

            int maxDigit = 0;
            int minDigit = 10;

            for (int i = 0; i < digits.Length; i++)
            {
                if (Convert.ToInt32(digits[i].ToString()) > maxDigit)
                {
                    maxDigit = Convert.ToInt32(digits[i].ToString());
                }
                if (Convert.ToInt32(digits[i].ToString()) < minDigit)
                {
                    minDigit = Convert.ToInt32(digits[i].ToString());
                }
            }

            //max
            if (!(int.Parse(digits.ToCharArray()[0].ToString()) == maxDigit))
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    if (int.Parse(digits[i].ToString()) == maxDigit)
                    {
                        max = int.Parse(SwapDigits(digits, i, 0));
                    }
                }
            }
            else max = number;

            //min
            if (!(int.Parse(digits.ToCharArray()[0].ToString()) == minDigit))
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    if (int.Parse(digits[i].ToString()) == minDigit)
                    {
                        min = int.Parse(SwapDigits(digits, i, 0));
                    }
                }
            }
            else min = number;

            Console.WriteLine(max);
            Console.WriteLine(min);
            return $"Min number: {min}; Max number: {max}";
        }

        public static string SwapDigits(string number, int index1, int index2)
        {
            char[] numberToReturn = number.ToCharArray();

            char helper = number[index1];

            numberToReturn[index1] = number[index2];
            numberToReturn[index2] = helper;

            return String.Join("", numberToReturn);
        }

    }
}
