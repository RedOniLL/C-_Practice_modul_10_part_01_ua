namespace C__Practice_modul_10_part_01_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choise");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 4:
                    Stack<int> intStack = new Stack<int>(5);
                    intStack.Push(1);
                    intStack.Push(2);
                    intStack.Push(3);
                    Console.WriteLine("Count: " + intStack.Count);
                    Console.WriteLine("Peek: " + intStack.Peek());
                    Console.WriteLine("Pop: " + intStack.Pop());
                    Console.WriteLine("Count after pop: " + intStack.Count);
                    break;
            }
        }
    }
}
