using System;

namespace Stack_Queues_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack1

            //Stack s = new Stack();//Create Stack Object
            //s.Add(70);
            //s.Add(30);
            //s.Add(56);
            //s.Display();//Call Display Method


            //Stack2
            //Stack s = new Stack();//Create Stack Object
            //s.Add(70);
            //s.Add(30);
            //s.Add(56);
            //s.Display();//Call Display Metho
            //s.peek();//Call Peek Method
            //s.pop();//Call pop Method
            //s.Display();

            //Queue1
            //Queue q = new Queue();//Create object Queue
            //q.Enqueue(70);//Add Datat Into The Queue
            //q.Enqueue(30);
            //q.Enqueue(56);
            //q.Display();//Call Display Method

            //Queues2

            Queue q = new Queue();//Create Objects 
            q.Enqueue(70);
            q.Enqueue(30);
            q.Enqueue(56);
            q.Display();
            q.Dequeue();
            q.Display();
        }
    }
}
