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

                do
                {
                    Console.WriteLine("Please enter a valid number");
                    input = Console.ReadLine();
                } while (string.IsNullOrEmpty(input));

                bool palindromeFoundFlag = false;

                int number = Convert.ToInt32(input);

                double totalLength = Math.Floor(Math.Log10(number) + 1);
                char[] inputArray = number.ToString().ToCharArray();

                //selecting number of digits in incremental order
                //using for loop, since it's faster than foreach
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
                                //Console.WriteLine(sum);
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
