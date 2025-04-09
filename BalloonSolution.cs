//Written by Shashank
//April 8, 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        int countB = 0;
        int countA = 0;
        int countL = 0;
        int countO = 0;
        int countN = 0;

        foreach (char c in text)
        {
            if (c == 'b')
            {
                countB++;
            }
            else if (c == 'a')
            {
                countA++;
            }
            else if (c == 'l')
            {
                countL++;
            }
            else if (c == 'o')
            {
                countO++;
            }
            else if (c == 'n')
            {
                countN++;
            }
        }

        countL /= 2;
        countO /= 2;

        int[] counts = { countB, countA, countL, countO, countN };
        int min = counts[0];

        for (int i = 1; i < counts.Length; i++)
        {
            min = Math.Min(min, counts[i]);
        }

        return min;
    }
}