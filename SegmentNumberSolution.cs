//Written by Shashank
//April 8, 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int CountSegments(string str)
    {
        if (str == null || str.Trim() == "")
        {  
            return 0; 
        }

        string[] parts = str.Split(' ');
        int count = 0;

        foreach (string part in parts)
        {
            if (part != "")
            {
                count++;
            }
        }

        return count;
    }
}

