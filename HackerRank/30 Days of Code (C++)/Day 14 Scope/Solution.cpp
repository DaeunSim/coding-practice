/*
  Author: https://www.hackerrank.com/profile/blondiebytes
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-scope/leaderboard
*/

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

class Difference {
    private:
    vector<int> elements;
  
  	public:
  	int maximumDifference;

    Difference(vector<int> a) {
        this->elements = a;
    }
	// Add your code here
    void computeDifference () {
        int max = 0;
        int diff = 0;
        int size = this->elements.size();

        for (int i = 0; i < size - 1; i++) {
            for (int j = 1; j < size; j++ ) {
                diff = this->elements[i] - this->elements[j];
                
                if (diff < 0)
                    diff *= -1;

                if (max < diff)
                    max = diff;
            }
        }

        maximumDifference = max;
    }

}; // End of Difference class

int main() {
    int N;
    cin >> N;
    
    vector<int> a;
    
    for (int i = 0; i < N; i++) {
        int e;
        cin >> e;
        
        a.push_back(e);
    }
    
    Difference d(a);
    
    d.computeDifference();
    
    cout << d.maximumDifference;
    
    return 0;
}
