using System;
namespace Calkowanie
{
    public class Calkowanie
    {
        public static void CalkowanieNieoznaczone(int najwiekszaPotega, int[] tablicaPrzedrostkow)
        {
            int index = 0;
            for (int i = najwiekszaPotega; i > 0; i--)
            {
                string przedrostek = tablicaPrzedrostkow[index] + "/" + Convert.ToString(i + 1) + "*";
                index++;
                int potega = i + 1; ;
                Console.Write(Convert.ToString(przedrostek) + "x^" + Convert.ToString(potega));
                if (i > 1)
                {
                    Console.Write("+");
                }
            }
            Console.Write(" + c");
        }

        public static void CalkowanieOznaczone(int najwiekszaPotega, int[] tablicaPrzedrostkow, int pierwszaWartosc, int drugaWartosc)
        {
            double pierwszyWynik = 0;
            double drugiWynik = 0;
            int index = 0;
            for (int i = najwiekszaPotega; i > 0; i--)
            {
                pierwszyWynik = pierwszyWynik + tablicaPrzedrostkow[index] * Math.Pow(pierwszaWartosc, i);
                drugiWynik = drugiWynik + tablicaPrzedrostkow[index] * Math.Pow(drugaWartosc, i);
                index++;
            }
            Console.WriteLine("\nWynik = " + Convert.ToString(pierwszyWynik - drugiWynik));

        }

    }
}