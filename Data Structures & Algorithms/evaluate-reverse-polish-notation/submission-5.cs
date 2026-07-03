public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string s in tokens) {
            if (int.TryParse(s, out int res))
                stack.Push(res);
            else {
                int y = stack.Pop();
                int x = stack.Pop();
                switch (s) {
                    case "+":
                        stack.Push(x + y);
                        break;
                    case "-":
                        stack.Push(x - y);
                        break;
                    case "*":
                        stack.Push(x * y);
                        break;
                    case "/":
                        stack.Push(x / y);
                        break;
                }
            }
        }

        return stack.Pop();
    }
}
