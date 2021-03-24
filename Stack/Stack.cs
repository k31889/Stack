using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack<T>
    {
        private T[] stack;
        private int top;

        public Stack(int depth)
        {
            stack = new T[depth];
            top = 0;
        }

        public void Push(T x)
        {
            if(top == stack.Length)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                stack[top] = x;
                Console.Write("Added: ");
                //stack[top].Print();
                top++;
            }
        }

        public T Pop()
        {
            if(top == 0)
            {
                Console.WriteLine("Stack is empty :)");
                return default(T);
            }
            else
            {
                top--;
                Console.Write("Removed: ");
                //stack[top].Print();                
                return stack[top++]; 
            }
        }
    }
}
