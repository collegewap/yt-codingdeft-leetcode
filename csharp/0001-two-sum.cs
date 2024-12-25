public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.length; i++) {
            if (seen.ContainsKey(target - nums[i])) {
                return new int[] {i, seen[target - nums[i]]};
            }
            seen[nums[i]] = i;
        }
        return new int[] {};
    }
} 