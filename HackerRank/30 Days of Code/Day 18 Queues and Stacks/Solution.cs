using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    //Write your code here
    List<char> stack = new List<char>();
    List<char> queue = new List<char>(); 

    void pushCharacter(char c)
    {
        if (Char.IsLower(c))
        {
            stack.Add(c);
        }
    }

    void enqueueCharacter(char c)
    {
        if (Char.IsLower(c))
        {
            queue.Insert(0, c);
        }
    }

    char popCharacter()
    {
        if (stack.Count > 0)
        {
            char c = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count -1);

            return c;
        }

        return '0';
    }

    char dequeueCharacter()
    {
        if (queue.Count > 0)
        {
            char c = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count -1);

            return c;
        }

        return '0';
    }


    static void Main(String[] args) 
    {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) 
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) 
        {
            if (obj.popCharacter() != obj.dequeueCharacter()) 
            {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) 
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else 
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}
