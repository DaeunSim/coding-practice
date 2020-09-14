/*
  Author: https://www.hackerrank.com/profile/blondiebytes
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-queues-stacks/leaderboard
*/

#include <iostream>
#include <queue>
#include <stack>

using namespace std;

class Solution {
    //Write your code here
    public:
        queue<char> queues;
        stack<char> stacks;

        void pushCharacter(char c) {
            stacks.push(c);
        }

        void enqueueCharacter(char c) {
            queues.push(c);
        }

        char popCharacter(){
            char c = '\n';

            if (!stacks.empty()) {
                c = stacks.top(); 
                stacks.pop();
            }

            return c;
        }

        char dequeueCharacter(){
            char c = '\n';

            if (!queues.empty()) {
                c = queues.front();
                queues.pop();
            }

            return c;
        }
};

int main() {
    // read the string s.
    string s;
    getline(cin, s);
    
  	// create the Solution class object p.
    Solution obj;
    
    // push/enqueue all the characters of string s to stack.
    for (int i = 0; i < s.length(); i++) {
        obj.pushCharacter(s[i]);
        obj.enqueueCharacter(s[i]);
    }
    
    bool isPalindrome = true;
    
    // pop the top character from stack.
    // dequeue the first character from queue.
    // compare both the characters.
    for (int i = 0; i < s.length() / 2; i++) {
        if (obj.popCharacter() != obj.dequeueCharacter()) {
            isPalindrome = false;
            
            break;
        }
    }
    
    // finally print whether string s is palindrome or not.
    if (isPalindrome) {
        cout << "The word, " << s << ", is a palindrome.";
    } else {
        cout << "The word, " << s << ", is not a palindrome.";
    }
    
    return 0;
}
