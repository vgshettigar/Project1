using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    // LeetCode #64.  Minimum Path Sum

    static int MinPathSum(int[][] arr)
    {
        int result = 0;

       

        return result;
    }

    static void Main(string[] args)
    {
        

        int[][] arr = new int[3][];

        for (int arrRowItr = 0; arrRowItr < 3; arrRowItr++)
        {
            arr[arrRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

       int sum = MinPathSum(arr);

        
    }
}
