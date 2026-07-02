public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else {
                if (stack.Count == 0)
                    return false;

                char popChar = stack.Pop();
                switch (c) {
                    case ')':
                        if (popChar != '(')
                            return false;
                        break;
                    case '}':
                        if (popChar != '{')
                            return false;
                        break;
                    case ']':
                        if (popChar != '[')
                            return false;
                        break;
                }
            }
        }

        return stack.Count == 0;
    }
}
