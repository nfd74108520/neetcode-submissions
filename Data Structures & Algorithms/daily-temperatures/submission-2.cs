public class Solution {
    public int[] DailyTemperatures(int[] t) {
        int[] result = new int[t.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < t.Length; i++) {
            while (stack.Count > 0 && t[i] > t[stack.Peek()]) {
                int p = stack.Pop();
                result[p] = i - p;
            }

            stack.Push(i);
        }

        return result;
    }
}
