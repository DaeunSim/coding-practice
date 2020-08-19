/*
  Author: https://www.hackerrank.com/profile/Shafaet
  Difficulty: Medium
  Submitted By: https://www.hackerrank.com/challenges/new-year-chaos/leaderboard
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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        int swapCnt = 0;
        int resultCnt = 0;
        int len = q.Length;

        while (true) {
            for (int i = 0; i < len - 1; i++) {
                // original index - current index > 2
                if ((q[i] - 1) - i > 2) {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                if (q[i] > q[i + 1]) {
                    int temp = q[i];
                    q[i] = q[i + 1];
                    q[i + 1] = temp;

                    swapCnt++; 
                }
            }

            if (swapCnt == 0)
                break;

            resultCnt += swapCnt;
            swapCnt = 0;
        }

        Console.WriteLine(resultCnt);
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q);
        }
    }
}
