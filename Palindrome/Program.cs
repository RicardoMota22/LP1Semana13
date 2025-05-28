using System;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool result = false;
                try
                {
                    result = IsPalindrome(arg);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Error.");
                    continue;
                }

                Console.WriteLine($"{arg} -> {result.ToString().ToLower()}");
            }
        }

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("Actually Input something");
            }

            if (input.Length < 2)
            {
                return true;
            }

            bool isPalindromeRecursive(string input)
            {
                int length = input.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (input[i] != input[length - 1 - i])
                    {
                        return false;
                    }
                }

                return true;
            }
            return isPalindromeRecursive(input);
        }
    }
}
