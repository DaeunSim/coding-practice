using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] actualDate = Console.ReadLine().Split(' ');
        string[] expectedDate = Console.ReadLine().Split(' ');

        int aYear = Convert.ToInt32(actualDate[2]);
        int aMonth = Convert.ToInt32(actualDate[1]);
        int aDay = Convert.ToInt32(actualDate[0]);

        int eYear = Convert.ToInt32(expectedDate[2]);
        int eMonth = Convert.ToInt32(expectedDate[1]);
        int eDay = Convert.ToInt32(expectedDate[0]);
        
        int fine = 0;

        if ((aYear < 1 || aYear > 3000) ||
            (eYear < 1 || eYear > 3000))
        {
            Console.WriteLine(fine);
            return;
        }

        if ((aMonth < 1 || aMonth > 12) ||
            (eMonth < 1 || eMonth > 12))
        {
            Console.WriteLine(fine);
            return;
        }

        if ((aDay < 1 || aDay > 31) ||
            (eDay < 1 || eDay > 31))
        {
            Console.WriteLine(fine);
            return;
        }

        if (aYear == eYear)
        {
            if (aMonth <= eMonth)
            {
                if (aDay <= eDay)
                {
                    fine = 0;
                }
                else
                {
                    fine = 15 * (aDay - eDay);
                }
            }
            else
            {
                fine = 500 * (aMonth - eMonth);
            }
        }
        else if (aYear < eYear)
        {
            fine = 0;
        }
        else
        {
            fine = 10000;
        }

        Console.WriteLine(fine);
    }
}
