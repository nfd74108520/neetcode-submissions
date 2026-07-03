public class MinStack {
    Stack<int> stack;
    Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>(new[] { int.MaxValue });
    }

    public void Push(int val) {
        stack.Push(val);
        if (minStack.Peek() >= val)
            minStack.Push(val);
    }

    public void Pop() {
        if (stack.Pop() == minStack.Peek())
            minStack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return minStack.Peek();
    }
}
