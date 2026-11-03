using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wonderful_string_tools
{
    public class StringTools
    {
        public static bool IsFirstWordLonger(string word1, string word2)
        {
            if (word1.Length > word2.Length)
                return true;
            return false;
        }

        public static long HowWordLonger(string word1, string word2)
            => Math.Abs(word1.Length - word2.Length);

        public static string ReverseWordsPrint(string input)
        {
            string[] r = input.Split(',');

            string s = "";
            for (int i = r.Length - 1; i > 0; i--)
                s += r[i] + ", ";
            s += r[0];

            return s;
        }

        public static string ToDoubleConsonants(string input)
        {
            string d = "";
            string consonants = "бвгджзйклмнпрстфхцчшщ";
            
            foreach (char c in input)
            {
                d += c;

                if (consonants.Contains(char.ToLower(c)))
                    d += c;
            }

            return d;
        }
    }
}
