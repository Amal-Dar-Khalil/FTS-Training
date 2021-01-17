using System;
using System.Collections.Generic;  

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> testStack = new MyStack<int>();
            try{
                testStack.Push(1);
                testStack.Print();
                testStack.Push(2);
                testStack.Print();
                Console.WriteLine(testStack.Peak()+"");
                testStack.Print();
                testStack.Push(3);
                testStack.Print();
                testStack.Pop();
                testStack.Print();
                testStack.Push(4);
                testStack.Print();
                testStack.Pop();
                testStack.Print();
                Console.WriteLine(testStack.Peak()+"");
                testStack.Print();
                testStack.Clear();
                testStack.Print();
                testStack.Pop();}
            catch(InvalidOperationException e){
                Console.WriteLine(e.Message);
            }

        }
    }

    public class MyStack<T> {
    List<T> stack;
    public MyStack() {
        this.stack = new List<T>();
    }
    
    public void Push(T x) {
        stack.Add(x);
    }
    
    public T Pop() {
        if(this.IsEmpty())
            throw new InvalidOperationException("The stack is empty!");
        T top = this.Peak();
        stack.RemoveAt(stack.Count - 1);
        return top;
    }
    
    public T Peak() {
        return stack[stack.Count - 1];
    }
    
    public void Clear(){
        this.stack.Clear();//or pop till the stack become empty.
    }
    public bool IsEmpty(){
        return (stack.Count == 0);
    }
    public void Print(){
        if(this.IsEmpty()){ 
            Console.WriteLine("____________________");
            return;}
        T element = this.Peak();
        Console.WriteLine(this.Pop()+"");
        this.Print();
        this.Push(element);
    }
}
}
