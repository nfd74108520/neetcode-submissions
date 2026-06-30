public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;
        HashSet<int> numsSet = new HashSet<int>(nums);

        int longest = 1;

        foreach (int num in numsSet) {
            int next = num + 1;
            int count = 1;
            while (numsSet.Contains(next)) {
                count++;
                next++;
            }
            if (count > longest)
                longest = count;
        }

        return longest;
    }
}
