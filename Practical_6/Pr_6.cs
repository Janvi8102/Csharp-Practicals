using System;

namespace Practical_6
{
    public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }

    class Pr_6
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }

}