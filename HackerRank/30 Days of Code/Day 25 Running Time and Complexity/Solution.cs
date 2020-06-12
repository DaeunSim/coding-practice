using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Int32.Parse(Console.ReadLine());
        while(T-->0)
        {
            int num = Int32.Parse(Console.ReadLine());
            IsPrime(num); 
        }
    }
    
    // This method divides n by each integer from 2 up to the square root of n.
    static void IsPrime(int num)
    {
        if (num <= 1)
        {
            Console.WriteLine("Not prime");
            return;
        }
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine("Not prime");
                return;
            }
        }

        Console.WriteLine("Prime");
    }
}
