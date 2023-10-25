namespace Calkowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programZakonczony = false;
            int najwiekszyWykladnik = 0;
            bool najwiekszyWykladnikPrawidlowy = false;

            while (programZakonczony == false)
            {
                Console.WriteLine("Podaj najwieksza potege dla x:");

                while (najwiekszyWykladnikPrawidlowy == false)
                {
                    najwiekszyWykladnik = Convert.ToInt32(Console.ReadLine());
                    if (najwiekszyWykladnik > 0)
                    {
                        najwiekszyWykladnikPrawidlowy = true;
                    }
                    else
                    {
                        Console.WriteLine("Wykladnik musi byc rowny lub wieszky od 0");
                    }

                }


                int[] przedrostki = new int[najwiekszyWykladnik + 1];
                int index = 0;
                for (int i = najwiekszyWykladnik; i > 0; i--)
                {
                    Console.WriteLine("Podaj przedrostek dla x^" + Convert.ToString(i));
                    int przedrostek = Convert.ToInt32(Console.ReadLine());
                    przedrostki[index] = przedrostek;
                    index++;
                }
                Console.WriteLine("\nFunkcja f(x): ");
                for (int i = 0; i < przedrostki.Length - 1; i++)
                {
                    Console.Write(Convert.ToString(przedrostki[i]) + "x^" + Convert.ToString(najwiekszyWykladnik - i));
                    if (najwiekszyWykladnik - i > 1)
                    {
                        Console.Write("+");
                    }
                }

                bool isDone = false;

                while (isDone == false)
                {
                    Console.WriteLine();

                    Console.WriteLine("\n\nWybierz całkowanie:");
                    Console.WriteLine("1. Oznaczone");
                    Console.WriteLine("2. Nieoznaczone");
                    Console.WriteLine("3. Zakonczenie Programu");

                    int task = Convert.ToInt32(Console.ReadLine());

                    if (task == 1)
                    {
                        Console.WriteLine("Wybrales calkowanie oznaczone");
                        Console.WriteLine("\nPodaj pierwsza liczbe:");
                        int pierwszaLiczba = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nPodaj druga liczbe:");
                        int drugaLiczba = Convert.ToInt32(Console.ReadLine());

                        Calkowanie.CalkowanieOznaczone(najwiekszyWykladnik, przedrostki, pierwszaLiczba, drugaLiczba);
                    }
                    if (task == 2)
                    {
                        Console.WriteLine("Wybrales calkowanie nieoznaczone");
                        Calkowanie.CalkowanieNieoznaczone(najwiekszyWykladnik, przedrostki);
                    }

                    if (task == 3)
                    {
                        isDone = true;
                        programZakonczony = true;
                    }
                }

            }
        }
    }
}