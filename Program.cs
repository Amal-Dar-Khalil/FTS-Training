using System;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyStack<int> testStack = new MyStack<int>();
            try
            {
                testStack.Push(1);
                testStack.Print();
                testStack.Push(2);
                testStack.Print();
                Console.WriteLine(testStack.Peak());
                testStack.Print();
                testStack.Push(3);
                testStack.Print();
                testStack.Pop();
                testStack.Print();
                testStack.Push(4);
                testStack.Print();
                testStack.Pop();
                testStack.Print();
                Console.WriteLine(testStack.Peak());
                testStack.Print();
                testStack.Clear();
                testStack.Print();
                testStack.Pop();
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

