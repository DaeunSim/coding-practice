/*
  Author: https://www.hackerrank.com/profile/AvmnuSng
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-sorting/leaderboard
*/

#include <bits/stdc++.h>

using namespace std;

int main() {
    int n;
    cin >> n;
    vector<int> a(n);
    for(int a_i = 0; a_i < n; a_i++){
    	cin >> a[a_i];
    }
    
    // Write Your Code Here
    int numSwaps = 0;
    int totalSwaps = 0;

    for (int i = 0; i < n; i++) {
        int numSwaps = 0;

        for (int j = 0; j < n - 1; j++) {
            if (a[j] > a[j + 1]) {
                int temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;

                numSwaps++;
            }
        }

        if (numSwaps == 0)
            break;
        
        totalSwaps += numSwaps;
    }

    cout << "Array is sorted in " << totalSwaps << " swaps." << endl;
    cout << "First Element: " << a[0] << endl;
    cout << "Last Element: " << a[n - 1] << endl;

    return 0;
}
