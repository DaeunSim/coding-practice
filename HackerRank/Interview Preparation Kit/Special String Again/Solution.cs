/*
  Author: https://www.hackerrank.com/profile/rock19
  Difficulty: Medium
  Submitted By: https://www.hackerrank.com/challenges/special-palindrome-again/leaderboard
*/

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

    // Hint 
    // 0 1 2 3 4
    // m m c m m
    // 2-0 == 4-2 calculation of difference between index
    
    // Complete the substrCount function below.    
    static long substrCount(int n, string s) {
        int substrCnt = s.Length;
        int diffIdx = -1;

        for (int i = 0; i < s.Length; i++) {
            diffIdx = -1;
            
            for (int j = i + 1; j < s.Length; j++) {
                if (s[i] == s[j]) {
                    // Case1: All of the characters are the same
                    // Case2: All characters except the middle one are the same
                    if (diffIdx == -1 || ((diffIdx - i) == (j - diffIdx))) {
                        substrCnt++;
                    }
                } else {
                    // Case3: Checking that all characters except the middle are identical
                    // Case4: All of the characters are not the same
                    if (diffIdx == -1) {
                        diffIdx = j;
                    } else {
                        break;
                    }
                }
            }
        }

        return substrCnt;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        long result = substrCount(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
