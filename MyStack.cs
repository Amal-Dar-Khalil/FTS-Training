using System;
using System.Collections.Generic;  
namespace Stack
{
    public class MyStack<T> : IMyStack<T>{
        private List<T> stack;
        public MyStack() 
        {
            this.stack = new List<T>();
        }
        
        public void Push(T x) 
        {
            stack.Add(x);
        }
        
        public T Pop() 
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty!");
            }
            T top = this.Peak();
            stack.RemoveAt(stack.Count - 1);
            return top;
        }
        
        public T Peak() 
        {
            return stack[stack.Count - 1];
        }
        
        public void Clear()
        {
            this.stack.Clear();//or pop till the stack become empty.
        }
        public bool IsEmpty()
        {
            return (stack.Count == 0);
        }
        public void Print()
        {
            if(this.IsEmpty())
            { 
                return;
            }
            T element = this.Peak();
            Console.WriteLine(this.Pop());
            this.Print();
            this.Push(element);
        }
    }
}