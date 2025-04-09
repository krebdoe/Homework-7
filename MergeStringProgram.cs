//Written by Shashank
//April 8, 2025

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        Console.WriteLine(sol.MergeAlternately("abc", "pqr"));    
        Console.WriteLine(sol.MergeAlternately("ab", "pqrs"));   
        Console.WriteLine(sol.MergeAlternately("abcd", "pq"));    
    }
}