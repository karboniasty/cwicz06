namespace _02_tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rozmiar = 10;
            int w = 0, k = 0, liczba = 1;
            int wiersz_gora = 0, wiersz_dol = rozmiar - 1, kolumna_lewa = 0, kolumna_prawa = rozmiar - 1;
            int[,] tablica = new int[rozmiar, rozmiar];

            while (liczba <= rozmiar * rozmiar)
            {
                while (k <= kolumna_prawa)
                {
                    tablica[w, k] = liczba;
                    liczba++;                    
                    k++;                    
                }
                k--;
                w++;
                while (w <= wiersz_dol)
                {
                    tablica[w, k] = liczba;
                    liczba++;                    
                    w++;                    
                }
                w--;
                k--;
                while (k >= kolumna_lewa)
                {
                    tablica[w, k] = liczba;
                    liczba++;                    
                    k--;                   
                }
                k++;
                w--;
                while (w > wiersz_gora)
                {
                    tablica[w, k] = liczba;
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

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}