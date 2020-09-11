/*
  Author: https://www.hackerrank.com/profile/Shafaet
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-2d-arrays/leaderboard
*/

#include <bits/stdc++.h>

using namespace std;

int GetMaximumSum(vector<vector<int>> &arr) {
    int max = -64;
    int sum = 0;
    int size = arr.size();

    for (int i = 0; i < size - 2; i++) {
        for (int j = 0; j < size - 2; j++) {
            sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                + arr[i + 1][j + 1]
                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

            if (max < sum)
                max = sum;  
        }
    }

    return max;
}

int main()
{
    vector<vector<int>> arr(6);
    for (int i = 0; i < 6; i++) {
        arr[i].resize(6);

        for (int j = 0; j < 6; j++) {
            cin >> arr[i][j];
        }

        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    int result = GetMaximumSum(arr);
    
    cout << result << endl;

    return 0;
}
