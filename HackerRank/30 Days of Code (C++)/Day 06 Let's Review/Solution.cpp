/*
  Author: https://www.hackerrank.com/profile/AllisonP
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-review-loop/leaderboard
*/

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <string>
using namespace std;

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */ 
    int testCases;
    cin >> testCases;

    for (int i = 0; i < testCases; i ++) {
        string inputStr = "";
        string oddStr = "";
        string evenStr = "";

        cin >> inputStr;

        for (int j = 0; j < inputStr.length(); j++) {
            if (j % 2 == 0) {
                evenStr += string(1, inputStr[j]);
            } else {
                oddStr += string(1, inputStr[j]);
            }
        }

        cout << evenStr + " " + oddStr << endl;          
    }  

    return 0;
}
