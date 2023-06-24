namespace _01_tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int [10,10];
            int liczba = 1;

            for (int i = 0; i < 10; i++)
            {
                for( int j = 0; j <10; j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}