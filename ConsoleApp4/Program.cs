namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opening = true;
            //Check();
            //bool succes = true;
            for (int i = 0; true;) 
            {
                char[] store = {'A', 'B', 'C', 'D'};
                if (opening ) {  opening = false; goto found;}
                char ADEnter = Console.ReadKey().KeyChar;
                found:
                Rebuild(ref i, ref store, ref ADEnter);
                foreach (char c in store)
                {
                    Console.Write(c + $"\t");
                }
                
                if (ADEnter == 97)
                {
                    i--;
                }
                if (ADEnter == 100)
                {
                    i++;
                }
                

            }
        }
        static void Rebuild (ref int i, ref char[] store, ref char ADEnter)
        {
            if (i<0) 
            i = 3;
            if (i > 3) i = 0;
            Console.Clear();
            store[i] = 'S';
            if (ADEnter == 13) Unbuild(ref i, ref store);
        }
        static void Unbuild (ref int i, ref char[] store)
        {
            Console.Clear();
            store[i] = 'F';
        }
        static void Check ()
        {
            
            while (true) { int X = Console.ReadKey().KeyChar;
            Console.WriteLine(X);}
        }
    }
}
