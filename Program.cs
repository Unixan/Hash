namespace Hash
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 4; i >= 0; i--)
            {
                AddEmpty(i);
                AddHash(8 - (2 * i));
                Console.WriteLine();
            }
            
            for (int i = 0; i < 4; i++)
            {
                AddEmpty(i);
                AddHash(8 - (2 * i));
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void AddEmpty(int index)
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write(" ");
            }
        }

        private static void AddHash(int index)
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write("#");
            }
        }

    }
}