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
            Stack s = new Stack();//Create Stack Object
            s.Add(70);
            s.Add(30);
            s.Add(56);
            s.Display();//Call Display Metho
            s.peek();//Call Peek Method
            s.pop();//Call pop Method
            s.Display();
        }
    }
}
