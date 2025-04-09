//Written by Shashank
//April 8, 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int sumS = 0; 
        int sumT = 0;

        foreach (char c in s)
        {
            sumS += c;
        }

        foreach (char c in t)
        {
            sumT += c;
        }

        return (char)(sumT - sumS);
    }
}
