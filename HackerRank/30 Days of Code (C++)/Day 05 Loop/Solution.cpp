/*
  Author: https://www.hackerrank.com/profile/AvmnuSng
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-loops/leaderboard
*/

#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    if (n < 2 || n > 20)
        return 0;

    for (int i = 1; i <= 10; i ++) {
        printf("%d x %d = %d\n", n, i, n * i);
    }

    return 0;
}
