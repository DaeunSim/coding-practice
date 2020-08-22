/*
  Author: https://www.hackerrank.com/profile/aa1992
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-conditional-statements/leaderboard
*/

#include <bits/stdc++.h>

using namespace std;

int main()
{
    int N;
    cin >> N;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    if (N % 2 == 1 || (N >= 6 && N <= 20)) {
        cout << "Weird" << endl;
    } else {
        cout << "Not Weird" << endl;
    }

    return 0;
}
