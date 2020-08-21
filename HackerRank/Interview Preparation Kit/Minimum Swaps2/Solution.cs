/*
  Author: https://www.hackerrank.com/profile/rishi_07
  Difficulty: Medium
  Submitted By: https://www.hackerrank.com/challenges/minimum-swaps-2/leaderboard
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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {
        int swapCnt = 0;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == i + 1)
                continue;

            int temp = arr[arr[i] - 1];
            arr[arr[i] - 1] = arr[i];
            arr[i] = temp;

            swapCnt++;
            i--;
        }

        return swapCnt;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
