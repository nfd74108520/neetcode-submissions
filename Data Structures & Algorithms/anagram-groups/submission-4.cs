public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string str in strs){
            string key = GetFingerPrint(str);
            
            if(!map.ContainsKey(key)) map.Add(key, new List<string>());

            map[key].Add(str);
        }
        
        List<List<string>> result = new List<List<string>>();
        foreach(var item in map){
            result.Add(item.Value);
        }

        return result;
    }

    public string GetFingerPrint(string s){
        int[] counts = new int[26];

        foreach(char c in s){
            counts[c - 'a']++;
        }

        return string.Join("-", counts);
    }
}
