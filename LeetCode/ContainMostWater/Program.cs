// See https://aka.ms/new-console-template for more information

int[] height = new[] {1,1};
Solution t = new Solution();
Console.WriteLine(t.MaxArea(height));

public class Solution
{
    public int MaxArea(int[] height)
    {
        (int, int)[] arr = new (int, int)[height.Length];
        for (int i = 0; i < height.Length; i++)
        {
            arr[i] = (height[i], i);
        }
        Array.Sort(arr);
        int min = arr[arr.Length - 1].Item2,max = arr[arr.Length - 1].Item2;
        int maxArea = 0;
        for(int i = arr.Length - 2; i >= 0; i--)
        {
            int maxCurArea = arr[i].Item1 * Math.Max(Math.Abs(arr[i].Item2 - min), Math.Abs(arr[i].Item2 - max));
            maxArea = Math.Max(maxCurArea, maxArea);
            min = Math.Min(min, arr[i].Item2);
            max = Math.Max(max, arr[i].Item2);
        }
        return maxArea;
    }
}
