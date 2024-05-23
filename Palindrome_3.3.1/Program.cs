using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine($"Is Eye :{isPalindrome("eye")}");   // Output: True
            Console.WriteLine($"Is Home:{isPalindrome("home")}");  // Output: False
            Console.ReadKey();
        }

        static bool isPalindrome(string s)
        {
            int left = 0;// Initialize left pointer to the beginning of the string;
            int right = s.Length - 1; //// Initialize right pointer to the end of the string
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;//left start 0 to increment
                right--;//right start minus from the end of right. 
            }                   
            return true;
          
            
        }
     
    }
}
