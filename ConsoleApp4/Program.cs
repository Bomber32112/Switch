using System.Diagnostics.Metrics;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check();
            bool opening = true;
            //Check();
            //bool succes = true;
            for (int i = 0; true;) 
            {
                char[] store = {'A', 'B', 'C', 'D'};
                if (opening ) Console.WriteLine("Нажмите на любую кнопку");
                byte ADEnter = (byte)Console.ReadKey().Key.GetHashCode();
                if (opening) { ADEnter = 0;  opening = false;}
                if (ADEnter == 37) i--;
                if (ADEnter == 39) i++;
                if (ADEnter == 192) break;

                Rebuild(ref i, ref store, ref ADEnter);
                Build(ref store);
            }
        }
        static void Rebuild (ref int i, ref char[] store, ref byte ADEnter)
        {
            if (i<0) 
            i = 3;
            if (i > 3) i = 0;
            Console.Clear();
            store[i] = 'S';
            if (ADEnter == 13) Build_Lock(ref i, ref store);
        }
        static void Build_Lock (ref int i, ref char[] store)
        {
            Console.Clear();
            store[i] = 'F';
            Build(ref store);
            while (true)
            {
                byte Enter = (byte)Console.ReadKey().Key.GetHashCode();
                Console.Clear();
                Build(ref store);
                if (Enter == 13) Console.WriteLine($"\n" + store[i]);
                if (Enter == 192) {Console.Clear(); store[i] = 'S'; break;}
            }
        }
        static void Build (ref char[] store)
        {
           Console.Write($"Нажмите '`' для выхода \n");
           foreach (char c in store)
           {
              Console.Write(c + $"\t");
           }
        }
        static void Check ()
        {
            
            while (true) { int X = Console.ReadKey().Key.GetHashCode();
                Console.WriteLine(X);}
        }
    }
}
