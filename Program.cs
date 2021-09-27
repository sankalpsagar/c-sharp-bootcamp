using System;

namespace multicastdemo
{
    class Program
    {
        static void Test() { }

        static void NewTest() { }


        static void Main(string[] args)
        {
            Action funObj1 = new Action(Program.Test);
            Action funObj2 = new Action(Program.NewTest);

            //funObj1 = (Action) System.Delegate.Combine(funObj1, funObj2);

            funObj1 = funObj1 + funObj2;
            Broadcast(funObj1);

            //can also do: funObj1 = funObj1 - funObj2

        }

        static void Broadcast (Action funcObj)
        {
            funcObj.Invoke();
        }
    }
}
