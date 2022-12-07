using System;

namespace Stack_Queues_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();//Create Stack Object
            s.Add(70);
            s.Add(30);
            s.Add(56);
            s.Display();//Call Display Method
        }
    }
}
