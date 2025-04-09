//Written by Shashank
//April 8, 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int i = 0;
        int j = 0;
        string result = "";

        while (i < word1.Length && j < word2.Length)
        {
            result += word1[i++];
            result += word2[j++];
        }

        while (i < word1.Length)
        {
            result += word1[i++];
        }

        while (j < word2.Length)
        {
            result += word2[j++];
        }

        return result;
    }
}

