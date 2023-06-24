namespace _03_tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tablica z zadania 1            
            int liczba1 = 1, rozmiar1;
            Console.Write("Podaj rozmiar tablicy: ");
            while (!int.TryParse(Console.ReadLine(), out rozmiar1) || rozmiar1 < 1)
            {
                Console.Write("Błędna Wartość. Podaj liczbę wierszy tablicy: ");
            }
            int[,] tablica1 = new int[rozmiar1, rozmiar1];

            for (int i = 0; i < rozmiar1; i++)
            {
                for (int j = 0; j < rozmiar1; j++)
                {
                    tablica1[i, j] = liczba1;
                    liczba1++;
                }
            }

            for (int i = 0; i < rozmiar1; i++)
            {
                for (int j = 0; j < rozmiar1; j++)
                {
                    Console.Write(tablica1[i, j] + " ");
                }
                Console.Write("\n");
            }

            //tablica z zadania 2            
            int w = 0, k = 0, liczba = 1, rozmiar2;
            Console.Write("\nPodaj rozmiar tablicy: ");
            while (!int.TryParse(Console.ReadLine(), out rozmiar2) || rozmiar2 < 1)
            {
                Console.Write("Błędna Wartość. Podaj liczbę wierszy tablicy: ");
            }
            int wiersz_gora = 0, wiersz_dol = rozmiar2 - 1, kolumna_lewa = 0, kolumna_prawa = rozmiar2 - 1;
            int[,] tablica2 = new int[rozmiar2, rozmiar2];

            while (liczba <= rozmiar2 * rozmiar2)
            {
                while (k <= kolumna_prawa)
                {
                    tablica2[w, k] = liczba;
                    liczba++;
                    k++;
                }
                k--;
                w++;
                while (w <= wiersz_dol)
                {
                    tablica2[w, k] = liczba;
                    liczba++;
                    w++;
                }
                w--;
                k--;
                while (k >= kolumna_lewa)
                {
                    tablica2[w, k] = liczba;
                    liczba++;
                    k--;
                }
                k++;
                w--;
                while (w > wiersz_gora)
                {
                    tablica2[w, k] = liczba;
                    liczba++;
                    w--;
                }
                w++;
                k++;
                wiersz_gora++;
                wiersz_dol--;
                kolumna_lewa++;
                kolumna_prawa--;
            }

            for (int i = 0; i < rozmiar2; i++)
            {
                for (int j = 0; j < rozmiar2; j++)
                {
                    Console.Write(tablica2[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}