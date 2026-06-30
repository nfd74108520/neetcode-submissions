public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> maps = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!maps.ContainsKey(num))
                maps[num] = 0;
            maps[num]++;
        }

        KeyValuePair<int, int>?[] heaps = new KeyValuePair<int, int>?[k];

        foreach (var map in maps) {
            KeyValuePair<int, int> tmp = map;
            for (int i = 0; i < heaps.Length; i++) {
                if (heaps[i] == null) {
                    heaps[i] = new KeyValuePair<int, int>(tmp.Key, tmp.Value);
                    break;
                }

                if (heaps[i].Value.Value < tmp.Value) {
                    KeyValuePair<int, int> copy = tmp;
                    tmp = heaps[i].Value;
                    heaps[i] = copy;
                }
            }
        }

        int[] result = new int[k];

        for (int i = 0; i < heaps.Length; i++) {
            result[i] = heaps[i].Value.Key;
        }

        return result;
    }
}
