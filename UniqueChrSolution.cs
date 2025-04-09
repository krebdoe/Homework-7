//Written by Shashank
//April 8, 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int FirstUniqChar(string str)
    {
        int[] freq = new int[26];

        foreach (char c in str)
        {
            freq[c - 'a']++;
        }

        for (int i = 0; i < str.Length; i++)
        {
            if (freq[str[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}

