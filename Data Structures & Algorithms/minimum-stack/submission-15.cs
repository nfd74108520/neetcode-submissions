public class MinStack {
    Stack<(int value, int minVal)> _stack = new Stack<(int value, int minVal)>();

    public MinStack() {}

    public void Push(int val) {
        int newMin = val;
        if (_stack.Count != 0)
            newMin = Math.Min(_stack.Peek().minVal, val);

        _stack.Push((val, newMin));
    }

    public void Pop() {
        _stack.Pop();
    }

    public int Top() {
        return _stack.Peek().value;
    }

    public int GetMin() {
        return _stack.Peek().minVal;
    }
}
