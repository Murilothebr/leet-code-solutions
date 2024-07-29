namespace Two_Sum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };


        MinStack minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        var one = minStack.GetMin(); // return -3
        minStack.Pop();
        var two =  minStack.Top();    // return 0
        var tree = minStack.GetMin(); // return -2

        Console.WriteLine(one);
        Console.WriteLine(two);
        Console.WriteLine(tree);
    }

}

public class MinStack
{
    public List<int> stack;

    public MinStack()
    {
        stack = new List<int>();
    }

    public void Push(int val)
    {
        stack.Add(val);
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
    }

    public int Top()
    {
        return stack[stack.Count - 1];
    }

    public int GetMin()
    {
        int min = int.MaxValue;

        foreach (int val in stack)
        {
            if (val < min)
                min = val;
        }

        return min;
    }
}
