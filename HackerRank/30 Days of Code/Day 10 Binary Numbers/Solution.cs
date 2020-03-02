using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void Main(string[] args) {
        int quotient = 1;
        int remainder = 0;
        int num = 0;
        int cnt = 0;
        int totalCnt = 0;

        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 1 || n > 1000000)
            return;

        num = n;

        if (num % 2 == 0)
            cnt = 1;
        else
            cnt = 0;

        while (num != 0)
        {
            quotient = num / 2;
            remainder = num % 2;

            if (remainder == 1)
            {
                cnt++;
            }
            else
            {
                cnt = 0;
            }

            if (totalCnt < cnt)
                totalCnt = cnt;
    
            num = quotient;
        }

        Console.Write(totalCnt);
    }
}
