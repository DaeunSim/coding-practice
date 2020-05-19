using System;
using System.Linq;

class Difference 
{
    private int[] elements;
    public int maximumDifference;
    public int count;

    public Difference(int[] elements)
    {
        this.elements = elements.ToArray();
    }

	// Add your code here
    public void computeDifference()
    {
	// Solution 1
        //int result = 0;

        //count = elements.Length;
        //for (int i = 0; i < count - 1; i++)
        //{
        //    for (int j = i + 1; j < count; j++)
        //    {
        //        if (elements[i] <= elements[j])
        //        {
        //            result = elements[j] - elements[i];
        //        }
        //        else
        //        {
        //            result = elements[i] - elements[j];
        //        }
        //   
        //        if (maximumDifference < result)
        //        {
        //            maximumDifference = result;
        //        }
        //    }
        //}
	
	// Solution 2
	maximumDifference = elements.Max() - elements.Min();
    }
} // End of Difference Class

class Solution 
{
    static void Main(string[] args) 
    {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        Difference d = new Difference(a);
        d.computeDifference();
        Console.Write(d.maximumDifference);
    }
}
