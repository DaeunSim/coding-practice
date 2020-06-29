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

class Solution 
{
    static void Main(string[] args) 
    {
        var lowerReg = new Regex(@"[a-z]");
        var addrReg = @"gmail.com";
        List<string> nameList = new List<string>();
        
        int N = Convert.ToInt32(Console.ReadLine());

        for (int NItr = 0; NItr < N; NItr++) 
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');
            string firstName = firstNameEmailID[0];
            string emailID = firstNameEmailID[1];

            string[] email = emailID.Split('@');
            string id = email[0];
            string addr = email[1];

            if (firstName.Length > 20 || emailID.Length > 50)
                continue;

            if (lowerReg.IsMatch(id) && addrReg.Equals(addr))
            {
                nameList.Add(firstName);
            }
        }

        nameList.Sort();

        foreach (string s in nameList)
        {
            Console.WriteLine(s);
        }
    }
}
