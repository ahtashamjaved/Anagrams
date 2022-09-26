using System;

namespace Anagrams // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";

            Console.WriteLine("Enter first string");
            s1 = Console.ReadLine();

            Console.WriteLine("Enter Second string");
            s2 = Console.ReadLine();

            Console.WriteLine();
            
            Console.WriteLine("Are Strings Anagrams : " + CheckAnagramsShort(s1, s2));
           
           // Console.WriteLine("Are Strings Anagrams : " + CheckAnagrams(s1, s2));
        }
        static bool CheckAnagramsShort(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            return false;
            char[] char_s1 = s1.ToCharArray();
            char[] char_s2 = s2.ToCharArray();
            
            Array.Sort(char_s1);
            Array.Sort(char_s2);

            Console.WriteLine();

            return char_s1.ToString() == char_s2.ToString();
        }

        static bool CheckAnagrams(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            return false;

            IDictionary<char, int> frequency1 = new Dictionary<char, int>();
            IDictionary<char, int> frequency2 = new Dictionary<char, int>();

            foreach(char ch in s1)
            {
                if(frequency1.Keys.Contains(ch))
                {
                    frequency1[ch] += 1;
                }
                else
                frequency1[ch] = 1;
            }

            foreach(char ch in s2)
            {
                if(frequency2.Keys.Contains(ch))
                {
                    frequency2[ch] += 1;
                }
                else
                frequency2[ch] = 1;
            }

            foreach(char key in frequency1.Keys)
            {
                if(!frequency2.Keys.Contains(key) || frequency1[key] != frequency2[key])
                return false;
            }
            return true;
        }
    }
}