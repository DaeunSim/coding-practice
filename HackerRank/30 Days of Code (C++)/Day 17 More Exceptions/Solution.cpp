/*
  Author: https://www.hackerrank.com/profile/Shafaet
  Difficulty: Easy
  Submitted By: https://www.hackerrank.com/challenges/30-more-exceptions/leaderboard
*/

#include <cmath>
#include <iostream>
#include <exception>
#include <stdexcept>
using namespace std;

class Calculator {
    public:
        int power(int n, int p) {            
            if (n < 0 || p < 0)
                throw runtime_error("n and p should be non-negative");

            return pow(n, p);
        }
};

int main()
{
    Calculator myCalculator=Calculator();
    int T,n,p;
    cin>>T;
    while(T-->0){
      if(scanf("%d %d",&n,&p)==2){
         try{
               int ans=myCalculator.power(n,p);
               cout<<ans<<endl; 
         }
         catch(exception& e){
             cout<<e.what()<<endl;
         }
      }
    }
}
