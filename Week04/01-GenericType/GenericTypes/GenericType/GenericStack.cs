using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class GenericStack<T>
    {
        public List<T> Stacks { get; private set; }

        public GenericStack()
        {
            Stacks = new List<T>(0);
        }

        public T Peek()
        {
            return Stacks[Stacks.Count - 1];
        }

        public T Pop()
        {
            T deletedElement = Stacks[Stacks.Count - 1];
            Stacks.RemoveAt(Stacks.Count - 1);
            return deletedElement;
        }

        public void Push(T element)
        {
            Stacks.Add(element);
        }

        public void Clear()
        {
            for (int i = 0; i < Stacks.Count; i++)
            {
                Stacks.RemoveAt(i);
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Stacks.Count; i++)
            {
                if (Stacks[i].Equals(element))
                    return true;
            }
            return false;
        }
    }
}

