namespace Stack
{
    /// <summary>
    /// This is IMYStack interface
    /// Contains all methods for performing basic stack functions.
    /// <list type="bullet">
    /// <item>
    /// <term>Push</term>
    /// <description>Stores an object on top of the stack.</description>
    /// </item>
    /// <item>
    /// <term>Pop</term>
    /// <description>Removes the object on top of the stack and returns it.</description>
    /// </item>
    /// <item>
    /// <term>Peak</term>
    /// <description>Prints the object on top of the stack if exists without removing it.</description>
    /// </item>
    /// <item>
    /// <term>Clear</term>
    /// <description>Removes all objects from the stack.</description>
    /// </item>
    ///<item>
    /// <term>Print</term>
    /// <description>Prints out all stack objects.</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IMyStack<T>
    {
        public void Push(T x);
        public T Pop();
        public T Peak();
        public void Clear();
        public void Print();
    }
}
