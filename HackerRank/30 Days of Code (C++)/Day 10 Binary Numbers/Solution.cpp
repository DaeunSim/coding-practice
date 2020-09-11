/*
  Author: https://www.hackerrank.com/profile/AvmnuSng
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-binary-numbers/leaderboard
*/

#include <bits/stdc++.h>

using namespace std;

int BinaryNumbers(int n) {
    int numbers = 0;
    int count = 0;
    int bit = -1;
    
    while (n) {
        bit = n & 1;
        n >>= 1;

        if (bit == 0) {
            count = 0;
            continue;
        }

        count++;

        if (numbers < count)
            numbers = count; 
    }

    return numbers;
}

int main()
{
    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int result = BinaryNumbers(n);

    cout << result << endl;

    return 0;
}
