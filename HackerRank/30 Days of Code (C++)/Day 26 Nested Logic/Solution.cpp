/*
  Author: https://www.hackerrank.com/profile/vatsalchanana
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-nested-logic/leaderboard
*/

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

void calculateFine(vector<int> &v1, vector<int> &v2) {
    int fine = 0;

    int diff_day = v1[0] - v2[0];
    int diff_month = v1[1] - v2[1];
    int diff_year = v1[2] - v2[2];

    if (diff_year == 0 && diff_month > 0) {
        fine = 500 * diff_month;
    } else if (diff_year == 0 && diff_day > 0) {
        fine = 15 * diff_day;
    } else if (diff_year > 0) {
        fine = 10000;
    } else {
        fine = 0;
    }

    cout << fine << endl;
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */ 
    vector<int> date(3);
    vector<int> due_date(3);

    cin >> date[0] >> date[1] >> date[2];
    cin >> due_date[0] >> due_date[1] >> due_date[2];

    calculateFine(date, due_date);
    
    return 0;
}
