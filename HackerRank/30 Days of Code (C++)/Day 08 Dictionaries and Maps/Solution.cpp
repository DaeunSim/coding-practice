#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <map>
#include <string>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */ 
    int n = 0;
    cin >> n;
    cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

    map<string, string> phoneBook;
    string name = "";
    string number = "";

    for (int i = 0; i < n; i++) {
        cin >> name;
        cin >> number;

        phoneBook.insert(pair<string, string>(name, number));
    }

    map<string, string>::iterator it;
    
    while (cin >> name && name != "") {
        it = phoneBook.find(name);

        if (it != phoneBook.end()) {
            cout << name << "=" << it->second << endl;
        } else {
            cout << "Not found" << endl;
        }
    }

    return 0;
}
