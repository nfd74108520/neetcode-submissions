public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string item in strs) {
            string key = GetFingerPrint(item);
            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(item);
        }

        List<List<string>> result = new List<List<string>>();

        foreach (var (key, value) in map) {
            result.Add(value);
        }

        return result;
    }

    public string GetFingerPrint(string s) {
        int[] counts = new int[26];
        foreach (char c in s) {
            counts[c - 'a']++;
        }

        return string.Join(",", counts);
    }
}
