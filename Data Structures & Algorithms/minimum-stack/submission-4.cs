public class MinStack {
    List<int> minStack;
    List<int> stack;

    public MinStack() {
        stack = new List<int>();
        minStack = new List<int>();
    }

    public void Push(int val) {
        stack.Add(val);
        if (minStack.Count == 0 || minStack[minStack.Count - 1] >= val)
            minStack.Add(val);
    }

    public void Pop() {
        int last = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        if (minStack[minStack.Count - 1] == last)
            minStack.RemoveAt(minStack.Count - 1);
    }

    public int Top() {
        return stack[stack.Count - 1];
    }

    public int GetMin() {
        return minStack[minStack.Count - 1];
    }
}
