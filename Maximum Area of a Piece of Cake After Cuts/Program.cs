using System;

namespace Maximum_Area_of_a_Piece_of_Cake_After_Cuts
{
  class Program
  {
    static void Main(string[] args)
    {
      int h = 1000000000;
      int w = 1000000000;
      var horizontalCuts = new int[] { 2 };
      var verticalCuts = new int[] { 2 };
      Solution s = new Solution();
      var answer = s.MaxArea(h, w, horizontalCuts, verticalCuts);
      Console.WriteLine(answer);
    }
  }


  public class Solution
  {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
    {
      // Step 1 -Sort both the arrays
      Array.Sort(horizontalCuts);
      Array.Sort(verticalCuts);

      long maxh = 0;
      // for first array item
      maxh = Math.Max(maxh, Math.Abs(horizontalCuts[0] - 0));
      for (int i = 1; i < horizontalCuts.Length; i++)
      {
        maxh = Math.Max(maxh, Math.Abs(horizontalCuts[i] - horizontalCuts[i - 1]));
      }
      // for last array item
      maxh = Math.Max(maxh, Math.Abs(h - horizontalCuts[^1]));


      long maxv = 0;
      // for first array item
      maxv = Math.Max(maxv, Math.Abs(verticalCuts[0] - 0));
      for (int i = 1; i < verticalCuts.Length; i++)
      {
        maxv = Math.Max(maxv, Math.Abs(verticalCuts[i] - verticalCuts[i - 1]));
      }
      // for last array item
      maxv = Math.Max(maxv, Math.Abs(w - verticalCuts[^1]));

      // Why % 1000000007, to handle large h and w values
      return (int)(maxh % 1000000007 * maxv % 1000000007);
    }
  }
}
