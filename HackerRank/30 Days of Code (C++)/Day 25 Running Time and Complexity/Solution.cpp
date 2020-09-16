/*
  Author: https://www.hackerrank.com/profile/blondiebytes
  Difficulty: Medium
  Submitted By: https://www.hackerrank.com/challenges/30-running-time-and-complexity/leaderboard
*/

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

void determinePrime(int n) {
    int count = 0;

    if (n == 1) {
        cout << "Not prime" << endl;
        return;
    }
    
    for (int i = 1; i <= sqrt(n); i++) {
        if (n % i == 0)
            count++;
    }

    if (count > 1) {
        cout << "Not prime" << endl;
    } else {
        cout << "Prime" << endl;
    }
}


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int t = 0;
    cin >> t;

    while (t > 0) {
        int n = 0;
        cin >> n;
        determinePrime(n);

        t--;
    }

    return 0;
}
