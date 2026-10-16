public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        int Total = 0;

        Array.Sort(nums);

        for (int i = 0, j = nums.Length - 1; i < j;)
        {
            if (nums[i] + nums[j] > k)
                j--;
            else if (nums[i] + nums[j] < k)
                i++;
            else
            {
                Total++;
                i++;
                j--;
            }
        }

        return Total;
    }
}