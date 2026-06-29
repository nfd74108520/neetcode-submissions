public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int> ();

        foreach(int item in nums){
            if(set.Contains(item)) return true;
            else set.Add(item);
        }

        return false;
    }
}