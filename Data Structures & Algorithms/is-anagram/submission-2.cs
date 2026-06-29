public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] checkArray = new int[26];
        for(int i = 0; i < s.Length; i++){
            int sIndex = s[i] - 'a';
            checkArray[sIndex]++;

            int tIndex = t[i] - 'a';
            checkArray[tIndex]--;
        }

        foreach(int item in checkArray){
            if(item != 0) return false;
        }

        return true;
    }
}
