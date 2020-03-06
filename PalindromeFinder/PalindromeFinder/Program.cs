using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = string.Empty;
                int number = 0;

                do
                {
                    Console.WriteLine("Please enter a valid number");
                    input = Console.ReadLine();

                } while (string.IsNullOrEmpty(input) || !Int32.TryParse(input, out number));

                bool palindromeFoundFlag = false;

                double totalLength = Math.Floor(Math.Log10(number) + 1);
                char[] inputArray = number.ToString().ToCharArray();

                //using for loop, since it's faster than foreach
                //to get all possible set of numbers from given number
                for (int i = 2; i <= totalLength; i++)
                {
                    for (int j = 0; j < totalLength; j++)
                    {
                        StringBuilder builder = new StringBuilder();
                        for (int x = j; x < j + i; x++)
                        {
                            if (x < totalLength)
                                builder.Append(inputArray[x]);
                            else
                                builder.Clear();
                        }

                        //check if the current number is palindrome
                        if (!string.IsNullOrEmpty(builder.ToString()))
                        {
                            long num, rem, sum = 0, temp;
                            num = Convert.ToInt32(builder.ToString());
                            temp = num;
                            while (num > 0)
                            {
                                rem = num % 10;
                                num = num / 10;
                                sum = sum * 10 + rem;
                            }
                            if (temp == sum)
                            {
                                palindromeFoundFlag = true;
                            }
                        }
                    }
                }

                Console.WriteLine("Palindrome Found:" + palindromeFoundFlag.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Message: " + ex.Message);
            }
        }
    }
}
