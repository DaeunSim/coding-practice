using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int cases = Int32.Parse(Console.ReadLine());

        if (cases < 1 || cases > 10)
            return;

        for (int i = 0; i < cases; i++)
            printEvenOddChar(Console.ReadLine());
    }

    static void printEvenOddChar(string s)
    {
        string even = string.Empty;
        string odd = string.Empty;

        int len = s.Length;

        if (len < 2 || len > 10000)
            return;
        
        for (int i = 0; i < len; i++)
        {
            if (i % 2 == 0)
                even += s.Substring(i, 1);
            else
                odd += s.Substring(i, 1);
        }

        Console.WriteLine("{0} {1}", even, odd);
    }
}
