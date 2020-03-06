using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Input = 2147483647;

                double totalLength = Math.Floor(Math.Log10(Input) + 1);
                List<int> possibleNumbers = new List<int>();
                char[] inputArray = Input.ToString().ToCharArray();

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
                            possibleNumbers.Add(Convert.ToInt32(builder.ToString()));
                    }
                }

                possibleNumbers.ForEach(x => { Console.WriteLine(x); });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Message: " + ex.Message);
            }
        }
    }
}
