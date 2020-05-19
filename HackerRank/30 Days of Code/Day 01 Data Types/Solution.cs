using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int r;
        double e;
        string g = "is the best place to learn and practice coding!";
        
        // Read and save an integer, double, and String to your variables.
        r = int.Parse(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        g = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + r);
    
        // Print the sum of the double variables on a new line.
        Console.WriteLine(string.Format("{0:0.0}", d+e));
 
        // Print as integer, not double
        //Console.Write(d + e);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.Write(s);
        Console.WriteLine(g);
    }
}
