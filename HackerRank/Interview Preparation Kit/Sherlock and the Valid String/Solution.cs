/*
  Author: https://www.hackerrank.com/profile/darkshadows
  Difficulty: Medium
  Submitted By: https://www.hackerrank.com/challenges/sherlock-and-valid-string/leaderboard
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

    // Complete the isValid function below.
    static string isValid(string s) {
        var list = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (list.ContainsKey(s[i])) {
                list[s[i]] += 1;
            } else {
                list.Add(s[i], 1);
            }
        }

        int count = 0;
        int value = list.ElementAt(0).Value;

        for (int j = 1; j < list.Count; j++) {
            if (list.ElementAt(j).Value != value) {
                count++;
            }

            if (count > 1) {
                return "NO";
            }
        }

        return "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
