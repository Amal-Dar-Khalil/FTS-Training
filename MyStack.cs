using System;
using System.Collections.Generic;  
namespace Stack
{
    public class MyStack<T> : IMyStack<T>
    {
        private List<T> data;
        private int topIndex { get =>  data.Count - 1; }
        public MyStack() 
        {
            this.data = new List<T>();
        }
        
        public void Push(T x) 
        {
            data.Add(x);
        }
        
        public T Pop() 
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty!");
            }
            T top = this.Peak();
            data.RemoveAt(topIndex);
            return top;
        }
        
        public T Peak() 
        {
            return data[topIndex];
        }
        
        public void Clear()
        {
            this.data.Clear();//or pop till the stack become empty.
        }
        public bool IsEmpty()
        {
            return (data.Count == 0);
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
