using System;
using System.Collections.Generic;  

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack testStack = new MinStack();
            testStack.Push(1);
            Console.WriteLine(testStack.GetMin()+"");
            testStack.Push(2);
            Console.WriteLine(testStack.GetMin()+"");
            Console.WriteLine(testStack.Top()+"");
            testStack.Push(3);
            testStack.Pop();
            Console.WriteLine(testStack.GetMin()+"");
            testStack.Push(4);
            Console.WriteLine(testStack.GetMin()+"");
            testStack.Pop();
            Console.WriteLine(testStack.Top()+"");

        }
    }

    public class MinStack {
    List<int> minStack;
    List<int> stack;
    public MinStack() {
        this.minStack = new List<int>();
        this.stack = new List<int>();
    }
    
    public void Push(int x) {
        stack.Add(x);
        if(minStack.Count == 0)
            minStack.Add(x);
        else if(x <= minStack[minStack.Count - 1])
            minStack.Add(x);
    }
    
    public void Pop() {
        if(stack[stack.Count - 1] == minStack[minStack.Count - 1])
            minStack.RemoveAt(minStack.Count - 1);//remove the min
        stack.RemoveAt(stack.Count - 1);//remove the top
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return minStack[minStack.Count - 1];
    }
    
    public bool IsEmpty(){
        return (stack.Count == 0);
    }
}
}
