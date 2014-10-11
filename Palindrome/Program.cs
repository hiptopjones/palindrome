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
                Console.WriteLine("{0}: {1}", i, CalculatePalindrome(i));
            }

            Console.WriteLine("Hit a key to continue...");
            Console.ReadKey();
        }

        static UInt64 CalculatePalindrome(UInt64 i)
        {
            UInt64 j = Reverse(i);
            UInt64 k = i + j;
            if (!IsPalindrome(k))
            {
                return CalculatePalindrome(k);
            }

            return k;
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
