using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt64 start = UInt64.Parse(args[0]);
            UInt64 end = UInt64.Parse(args[1]);

            for (UInt64 i = start; i <= end; i++)
            {
                UInt64 palindrome;
                UInt64 iterations = 0;
                CalculatePalindrome(i, ref iterations, out palindrome);
                Console.WriteLine("{0}: {1} (x{2})", i, palindrome, iterations);
            }

            Console.WriteLine("Hit a key to continue...");
            Console.ReadKey();
        }

        static void CalculatePalindrome(UInt64 i, ref UInt64 iterations, out UInt64 palindrome)
        {
            iterations++;

            UInt64 j = Reverse(i);
            UInt64 k = i + j;
            if (!IsPalindrome(k))
            {
                CalculatePalindrome(k, ref iterations, out palindrome);
                return;
            }

            palindrome = k;
        }

        static bool IsPalindrome(UInt64 k)
        {
            return (k == Reverse(k));
        }

        static UInt64 Reverse(UInt64 i)
        {
            char[] forward = i.ToString().ToCharArray();
            char[] backward = forward;
            Array.Reverse(backward);

            return UInt64.Parse(new string(backward));
        }
    }
}
