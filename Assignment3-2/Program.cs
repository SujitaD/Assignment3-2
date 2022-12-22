using System;

namespace Assignment3_2
{
    class Mystack : ICloneable 
    {
        readonly int[] a = new int[5];
        int top = -1;
        int n;

        public Mystack()
        { }

        public Mystack(int n)
        {
            this.n = n;

        }
        public object Clone()
        {
            Mystack m = new Mystack();
            m.n = this.n;
            return m;
        }
        bool IsEmpty()
        {
            return (top < 0);
        }
        internal bool Poos(int val) 
        {
            if(top >= n)
            {
                try
                {
                    throw new Exception("Stack Overflow");
                }
                catch
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
            }
            else
            {
                a[++top] = val;
                return true;
            }
        }
        
        internal int Pop()
        {
            if (top < 0)
            {
                try
                {
                    throw new Exception("Stack Underflow");
                }
                catch
                {
                    Console.WriteLine("Stack Underflow");

                }
                return 0;
            }
            else
            {
                int value = a[top--];
                return value;
            }
        }
        internal void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine("The values in stack are:");
                for(int i= top;i>=0;i--)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mystack s = new Mystack(2);
            Mystack s1 = s.Clone() as Mystack;
            s1= s;
            s1.Poos(10);
            s1.Poos(20);
            s1.Poos(30);

            s1.PrintStack();
            Console.WriteLine("Items popped from the stack:" + s.Pop());
            s1.PrintStack();


        }
    }

}