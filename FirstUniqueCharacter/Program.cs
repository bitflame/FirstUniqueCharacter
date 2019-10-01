using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUniqueCharacter
{
    public class Program
    {
        static void Main(string[] args)
        {
            String s = "leetcode";
            Console.WriteLine(FirstUniqueCharacter(s));
            Console.ReadLine();
        }
        public static int FirstUniqueCharacter(String s)
        {
            //retrun the index of first unique character in a string
            int[] charCount = new int[26];
            foreach (var c in s)
            {
                charCount[c - 'a']++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
