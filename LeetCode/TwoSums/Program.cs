// See https://aka.ms/new-console-template for more information

int target = 11;
int[] num = new[] {1,1,1,1,4,7};

Solution t = new Solution();
var result = t.TwoSum(num, target);
foreach(int i in result)
{
    Console.Write($"{i},");
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> number = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int a = nums[i];
            if (number.ContainsKey(target - a))
            {
                return new int[] { i, number[target - a] };
            }
            number[a] = i;
        }
        return null;
    }
}
