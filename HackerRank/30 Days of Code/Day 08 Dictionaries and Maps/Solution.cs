using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();
        string[] info = new string[2];
        string name = string.Empty;

        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 100000)
            return;

        for (int i = 0; i < n; i++)
        {
            info = Console.ReadLine().Split(' ');

            if (info[1] != null)
                phoneBook.Add(info[0], int.Parse(info[1]));
        }
        
        while ((name = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("{0}={1}", name, phoneBook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
