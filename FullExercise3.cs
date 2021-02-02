using System.Collections.Generic;

namespace Background1
{
    public delegate int TransformationFunction(int value);

    public static class FullExercise3
    {
        
        public static IEnumerable<int> Transform(this IEnumerable<int> data, TransformationFunction TFunc)
        {
            foreach (var value in data)
            {
                yield return TFunc(value);
            }
        }
    }
}
