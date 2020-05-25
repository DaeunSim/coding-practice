sing System;

class Node
{
    public Node left,right;
    public int data;
    public Node(int data)
    {
        this.data=data;
        left=right=null;
    }
}

class Solution
{
  // Not solved.
  // Refer to discussions page
  static int getHeight(Node root)
  {
      //Write your code here
        int height = 0;

        if (root == null)
            return -1;
        
        int left = getHeight(root.left) + 1;
        int right = getHeight(root.right) + 1;

        if (left < right)
        {
            height = right;
        }
        else
        {
            height = left;
        }

        return height;
    }

    static Node insert(Node root, int data)
    {
        if(root==null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if(data<=root.data)
            {
                cur=insert(root.left,data);
                root.left=cur;
            }
            else
            {
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    
    static void Main(String[] args)
    {
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0)
        {
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
    }
}
