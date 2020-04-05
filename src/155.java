
import java.util.Stack;

class MinStack {

    /** initialize your data structure here. */
    private Stack<Integer> data;
    private Stack<Integer> minRec;

    public MinStack() {
        data = new Stack<>();
        minRec = new Stack<>();
    }

    public void push(int x) {
        data.add(x);
        if (minRec.isEmpty() || minRec.peek() >= x) {
            minRec.add(x);
        }
    }

    public void pop() {
        if (!data.isEmpty()) {
            int res = data.pop();
            if (res == minRec.peek()) {
                minRec.pop();
            }
        }
    }

    public int top() {
        if (!data.isEmpty()) {
            return data.peek();
        } else {
            throw new RuntimeException("Stack is empty");
        }
    }

    public int getMin() {
        if (!minRec.isEmpty()) {
            return minRec.peek();
        } else {
            throw new RuntimeException("No data.");
        }
    }

    public static void main(String[] args) throws Exception {
        MinStack minStack = new MinStack();
        minStack.push(512);
        minStack.push(-1024);
        minStack.push(-1024);
        minStack.push(512);
        System.out.println(minStack.getMin());
        minStack.pop();
        System.out.println(minStack.getMin());
        minStack.pop();
        System.out.println(minStack.getMin());
        minStack.pop();
        System.out.println(minStack.getMin());
        minStack.pop();
    }
}