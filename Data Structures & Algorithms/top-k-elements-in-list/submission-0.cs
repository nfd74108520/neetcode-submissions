public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 0;
            }
            map[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var (key, value) in map) {
            if (buckets[value] == null) {
                buckets[value] = new List<int>();
            }
            buckets[value].Add(key);
        }

        int[] result = new int[k];
        int resultIndex = 0;

        for (int i = buckets.Length - 1; i > 0; i--) {
            if (buckets[i] == null) {
                continue;
            }
            foreach (int item in buckets[i]) {
                result[resultIndex++] = item;

                if (resultIndex == k) {
                    return result;
                }
            }
        }

        return result;
    }
}