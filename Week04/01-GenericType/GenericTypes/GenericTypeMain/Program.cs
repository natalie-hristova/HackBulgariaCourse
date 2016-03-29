using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericType;

namespace GenericTypeMain
{
    class Program
    {
        static void Main(string[] args)
        {
            // GenericStack <int > stack = new GenericStack <int>();
            // stack.Push(42);
            // stack.Push(4543);
            // stack.Push(12);
            // stack.Pop();
            // Console.WriteLine(stack.Peek());
            // Console.WriteLine(stack.Contains(12));
            // Console.WriteLine(stack.Contains(42));
            //stack.Clear();
            //GenericDequeue<int> queue = new GenericDequeue<int>();
            //queue.AddToFront(1);
            //queue.AddToFront(2);
            //queue.AddToFront(3);
            //queue.AddToFront(4);
            //queue.AddToEnd(-1);
            //queue.AddToEnd(-2);
            //queue.AddToEnd(-3);
            //Console.WriteLine(queue.PeekFromEnd());
            //Console.WriteLine(queue.PeekFromFront());
            //queue.RemoveFromEnd();
            //queue.RemoveFromFront();
            //Console.WriteLine(queue.Contains(2));
            //Console.WriteLine(queue.Contains(12));
            //queue.Clear();
            //queue.Clear();
            //Combination<int, string> winningCombo = new Combination<int, string>(1, 2, 3, "a", "b", "c");
            //LottoGame < int, string> lg = new LottoGame<int, string>(winningCombo);
            LottoGame<int, string>.PlayersCombination();
        }
    }
}
