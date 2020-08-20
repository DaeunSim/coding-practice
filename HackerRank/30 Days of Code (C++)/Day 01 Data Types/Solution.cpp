/*
  Author: https://www.hackerrank.com/profile/AllisonP
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-data-types/leaderboard
*/

#include <iostream>
#include <iomanip>
#include <limits>

using namespace std;

int main() {
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";

    // Declare second integer, double, and String variables.
    int inputInt = 0;
    double inputDbl = 0.0;
    string inputStr = "";
    
    // Read and save an integer, double, and String to your variables.
    // Note: If you have trouble reading the entire string, please go back and review the Tutorial closely.
    cin >> inputInt;
    cin >> inputDbl;
    getline(cin >> ws, inputStr);
    
    // Print the sum of both integer variables on a new line.
    cout << i + inputInt << endl;

    // Print the sum of the double variables on a new line.
    cout << fixed << setprecision(1) << d + inputDbl << endl;
    
    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    cout << s + inputStr << endl;

    return 0;
}
