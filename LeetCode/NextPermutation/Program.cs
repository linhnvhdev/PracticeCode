// See https://aka.ms/new-console-template for more information
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int index = n - 1;
        while(index >= 0 && nums[index-1] >= nums[index])
        {
            index--;
        }
        if (index < 0)
        {
        }
        else
        {

        }
    }
}