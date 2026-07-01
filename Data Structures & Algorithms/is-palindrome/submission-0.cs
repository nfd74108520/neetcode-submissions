public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        while (l < r) {
            if (Char.IsLetterOrDigit(s[l]) && Char.IsLetterOrDigit(s[r])) {
                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                    return false;
                else {
                    l++;
                    r--;
                    continue;
                }
            }

            if (!Char.IsLetterOrDigit(s[l]))
                l++;

            if (!Char.IsLetterOrDigit(s[r]))
                r--;
        }

        return true;
    }
}
