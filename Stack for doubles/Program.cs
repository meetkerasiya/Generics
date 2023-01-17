using System;

namespace Stack_for_doubles
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            StackCollectionDouble();
        }

        private static void StackCollectionDouble()
        {
            var stack = new Stack<double>();
            stack.Push(2.5);
            stack.Push(3.8);
            stack.Push(4.0);
            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = (double)stack.Pop();
                Console.WriteLine("Item: " + item);
                sum += item;
            }
            Console.WriteLine("Sum: " + sum);

        }

        private static void StackDoubles()
        {
            //var stack = new SimpleStackDouble();
            var stack = new SimpleStack<double>();
            stack.Push(2.5);
            stack.Push(3.8);
            stack.Push(4.0);
            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item =(double) stack.Pop();
                Console.WriteLine("Item: " + item);
                sum += item;
            }
            Console.WriteLine("Sum: " + sum);
        }
        private static void StackStrings()
        {
           //var stack=new SimpleStackString();
            var stack=new SimpleStack<string>();
            stack.Push("Hello");
            stack.Push("Hola"); 
           
            while (stack.Count > 0) 
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}