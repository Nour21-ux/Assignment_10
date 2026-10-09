using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10
{
    public class FirstUniqueChar
    {
        public static int FindFirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;

            Dictionary<char, int> charcont = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charcont.ContainsKey(c)) 
                {
                    charcont[c]++;
                }
                else
                    charcont[c] = 1;
            }

            for (int i = 0; i < s.Length; i++) 
            {
                if (charcont[s[i]]==1)
                    return i;
            }
            return-1;
        }
    }
}
