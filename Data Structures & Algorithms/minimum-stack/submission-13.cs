public class MinStack {
    Stack<(int value, int minVal)> _stack;

    public MinStack() {
        _stack = new Stack<(int value, int minVal)>();
    }

    public void Push(int val) {
        if (_stack.Count == 0)
            _stack.Push((val, val));
        else {
            int curMin = _stack.Peek().minVal;
            _stack.Push((val, Math.Min(curMin, val)));
        }
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
