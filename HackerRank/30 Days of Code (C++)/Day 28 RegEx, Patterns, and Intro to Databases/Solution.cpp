/*
  Author: https://www.hackerrank.com/profile/AvmnuSng
  Difficulty: Medium
  Submitted By: https://www.hackerrank.com/challenges/30-regex-patterns/leaderboard
*/

#include <bits/stdc++.h>

using namespace std;

vector<string> split_string(string);

bool checkName(string s) {
    if (regex_match(s, regex("[a-z]+")))
        return true;

    return false;
}

bool checkEmail(string s) {
    if (regex_match(s, regex("[.a-z]+\@gmail.com")))
        return true;

    return false;
}

void printFirstNames(multiset<string> &s){
    multiset<string>::iterator it;
    
    for (it = s.begin(); it != s.end(); it++) {
        cout << *it << endl;
    }
}

int main()
{
    int N;
    cin >> N;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    multiset<string> names;

    for (int N_itr = 0; N_itr < N; N_itr++) {
        string firstNameEmailID_temp;
        getline(cin, firstNameEmailID_temp);

        vector<string> firstNameEmailID = split_string(firstNameEmailID_temp);

        string firstName = firstNameEmailID[0];

        string emailID = firstNameEmailID[1];
        
        //Write code
        if (checkName(firstName) && checkEmail(emailID)) {
            names.insert(firstName);
        }
    }

    printFirstNames(names);

    return 0;
}

vector<string> split_string(string input_string) {
    string::iterator new_end = unique(input_string.begin(), input_string.end(), [] (const char &x, const char &y) {
        return x == y and x == ' ';
    });

    input_string.erase(new_end, input_string.end());

    while (input_string[input_string.length() - 1] == ' ') {
        input_string.pop_back();
    }

    vector<string> splits;
    char delimiter = ' ';

    size_t i = 0;
    size_t pos = input_string.find(delimiter);

    while (pos != string::npos) {
        splits.push_back(input_string.substr(i, pos - i));

        i = pos + 1;
        pos = input_string.find(delimiter, i);
    }

    splits.push_back(input_string.substr(i, min(pos, input_string.length()) - i + 1));

    return splits;
}
