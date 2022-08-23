// See https://aka.ms/new-console-template for more information
int[] nums = new[] { -1, 0, 1, 2, -1, -4 };
Solution t = new Solution();
var result = t.ThreeSum(nums);
foreach(var li in result)
{
    foreach(var num in li)
    {
        Console.Write($"{num}, ");
    }
    Console.WriteLine();
}

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        int n = nums.Length;
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0;i < nums.Length; i++)
        {
            int x = nums[i];
            if (i > 0 && x == nums[i - 1]) continue;
            TwoSum(result,x, i+1);
        }

        void TwoSum(IList<IList<int>> result, int x,int from)
        {
            int sum = -x;
            int l = from;
            int r = nums.Length - 1;
            while(l < r)
            {
                if (nums[l] + nums[r] < sum) l++;
                else if (nums[l] + nums[r] > sum) r--;
                else
                {
                    List<int> newList = new List<int>();
                    newList.AddRange(new[] { x, nums[l], nums[r] });
                    result.Add(newList);
                    int curNumL = nums[l];
                    int curNumR = nums[r];
                    while (l < nums.Length && nums[l] == curNumL) l++;
                    while (r >= 0 && nums[r] == curNumR) r--;
                }
            }
        }
        return result;
    }
}
