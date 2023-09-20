using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefinideClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack
            Stack<int> stack = new Stack<int>();

            // Add elements to the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Access the top element of the stack
            int topElement = stack.Peek();
            Console.WriteLine("Element at the top of the stack: " + topElement);

            // Remove elements from the stack
            while (stack.Count > 0)
            {
                int poppedElement = stack.Pop();
                Console.WriteLine("Popped element: " + poppedElement);
            }

            // Create a queue
            Queue<int> queue = new Queue<int>();

            // Add elements to the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Access the element at the front of the queue
            int frontElement = queue.Peek();
            Console.WriteLine("Element at the front of the queue: " + frontElement);

            // Remove elements from the queue
            while (queue.Count > 0)
            {
                int dequeuedElement = queue.Dequeue();
                Console.WriteLine("Dequeued element: " + dequeuedElement);
            }
        }
    }
}
