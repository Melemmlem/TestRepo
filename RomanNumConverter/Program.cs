

using System.Globalization;
using System.Security;

Solution Solution = new Solution();
int[] arr = { 2, 7, 11, 15 };
int t = 18;
int[] arr2 = Solution.TwoSum(arr, t);
foreach (int i in arr2)
{
    Console.WriteLine(i);
}

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                a = i;

                for (int j = 0; j < nums.Length; j++)
                {
                    b = j;

                    if (a != b && nums[a] + nums[b] == target)
                        break;
                    else
                        continue;
                }

                if (a != b && nums[a] + nums[b] == target)
                    break;
                else
                    continue;
            }
            return new int[] { a, b };
        }
    }






