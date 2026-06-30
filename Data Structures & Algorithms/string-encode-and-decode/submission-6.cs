public class Solution {
    public string Encode(IList<string> strs) {
        string result = string.Empty;

        foreach (string str in strs) {
            result += str;
            result += '`';
        }

        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        string tmp = string.Empty;
        foreach (char c in s) {
            if (c == '`') {
                result.Add(tmp);
                tmp = string.Empty;
            } else
                tmp += c;
        }

        return result;
    }
}
