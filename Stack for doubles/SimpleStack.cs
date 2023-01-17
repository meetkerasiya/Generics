namespace Stack_for_doubles
{
    /*
     //use of object instead of data type
    public class SimpleStack
    {
        private readonly object[] _items;
        private int _currentIndex = -1;
        public SimpleStack() => _items = new object[10];

        public int Count => _currentIndex + 1;
        public void Push(object item) => _items[++_currentIndex] = item;

        public object Pop() => _items[_currentIndex--];
    }
    */
    /*
    //duplication to create type safe
    public class SimpleStackDouble

    {
        private readonly double[] _items;
        private int _currentIndex = -1;
        public SimpleStackDouble() => _items = new double[10];

        public int Count => _currentIndex + 1;
        public void Push(double item) => _items[++_currentIndex] = item;

        public double Pop() => _items[_currentIndex--];
    }

    public class SimpleStackString
    {
        private readonly string[] _items;
        private int _currentIndex = -1;
        public SimpleStackString() => _items = new string[10];

        public int Count => _currentIndex + 1;
        public void Push(string item) => _items[++_currentIndex] = item;

        public string Pop() => _items[_currentIndex--];
    }
    */

    //use Generics
    //T is TypePlaceHolder
    public class SimpleStack<T>
    {
        private readonly T[] _items;
        private int _currentIndex = -1;
        public SimpleStack() => _items = new T[10];

        public int Count => _currentIndex + 1;
        public void Push(T item) => _items[++_currentIndex] = item;

        public T Pop() => _items[_currentIndex--];
    }

}