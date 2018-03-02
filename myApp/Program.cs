using System;
using System.IO;


namespace System.Runtime.Loader
{
  public static class runner
  {
    public static int i=0;
  }
    class Program
    {
      private static void unloadTask(AssemblyLoadContext obj)
      {
          runner.i=1;
          Console.WriteLine("Kill signal received");
          System.Threading.Thread.Sleep(800);
          Console.WriteLine("Oh wait I have a task to finish...");
          System.Threading.Thread.Sleep(800);
          Console.WriteLine("97%");
          System.Threading.Thread.Sleep(800);
          Console.WriteLine("98%");
          System.Threading.Thread.Sleep(800);
          Console.WriteLine("99%");
          System.Threading.Thread.Sleep(800);
          Console.WriteLine("100%");
          System.Threading.Thread.Sleep(800);
          Console.WriteLine("Exiting now");
      }

        static void Main(string[] args)
        {
            AssemblyLoadContext.Default.Unloading += unloadTask;
            while(true && runner.i==0)
            {
              Console.WriteLine("******");
              Console.WriteLine("Hello this is a .NET CORE running app!");
              Console.WriteLine("******");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
