int[] arr = { 2, 15, 7, 11 };
int target = 9;
int[] indices = TwoSum(arr, target);
Console.WriteLine($"[{indices[0]}, {indices[1]}]");

int[] TwoSum(int[] nums, int target)
{
    int[] ind = new int[2];
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                ind[0] = i;
                ind[1] = j;
                return ind;
            }
        }
    }
    return ind;
}