namespace Stack
{
    public interface IMyStack<T>
    {
        public void Push(T x);
        public T Pop();
        public T Peak();
        public void Clear();
        public void Print();
    }
}