using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    public class MinStack
    {
        private Stack<(int, int)> data;
        private int min;

        public MinStack()
        {
            data = new Stack<(int, int)>();
            min = int.MaxValue;
        }

        public void Push(int val)
        {
            data.Push((val, min));
            min = Math.Min(val, min);
        }

        public void Pop()
        {
            var elem = data.Peek();
            min = elem.Item2;
            data.Pop();
        }

        public int Top()
        {
            return data.Peek().Item1;
        }

        public int GetMin()
        {
            return min;
        }
    }
}
