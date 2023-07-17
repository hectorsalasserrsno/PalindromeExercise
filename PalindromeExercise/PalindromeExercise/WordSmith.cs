using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str) 
        {
            string reversedWord = string.Empty;

            for (int i = str.Length -1; i >= 0; i--) 
                {
                reversedWord += str[i];
                }
            if (str == reversedWord) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        
        }

    }
}
