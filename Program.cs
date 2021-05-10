using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_ITE
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>


        private static int system = 13; // <---- tutaj wstaw wielkoœæ pierœcienia
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void IloscOdwracalnych() // <---- iloœæ elementów odwracalnych
        {
            int result = 0;
            for (int i = 1; i < system; i++)
            {
                if (Nwd(system, i) == 1)
                {
                    result++;
                }
            }
            Console.WriteLine($"Iloœæ elementów odwracalnych w systemie {system}: {result}");
        }
        private static void ElementOdwrotnyDodawanie(int skladnik) // <---- element odwracalny wzglêdem dodawania
        {
            int result = 0;

            while ((skladnik + result) % system != 0) result++;

            Console.WriteLine($"Element odwrotny dodawania w {system} do {skladnik} to {result}");
        }
        private static void ElementOdwrotnyMnozenie(int skladnik) // <---- element odwracalny wzglêdem mno¿enia
        {
            int result = 0;

            while ((skladnik * result) % system != 1)
            {
                result++;
                if (result > system)
                {
                    Console.WriteLine($"Element odwrotny mnozenia w {system} do { skladnik } nie istnieje");
                    return;
                }
            }

            Console.WriteLine($"Element odwrotny mno¿enia w {system} do {skladnik} to {result}");
        }
        private static int ElementOdwrotnyMnozenieInt(int skladnik, int nwd) // <---- tego nie u¿ywaj
        {
            int result = 0;
            int system = Program.system / nwd;
            while ((skladnik * result) % system != 1)
            {
                result++;
            }
            return result;
        }
        private static void Tablice() // <---- wyœwietla tablice dodawania i mno¿enia w danym pierœcieniu
        {
            Console.WriteLine($"System:{system}");
            Console.WriteLine("Dodawanie:");
            for (int i = 0; i < system; i++)
            {
                for (int j = 0; j < system; j++)
                {
                    Console.Write((i + j) % system + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Mno¿enie:");
            for (int i = 0; i < system; i++)
            {
                for (int j = 0; j < system; j++)
                {
                    Console.Write((i * j) % system + " ");
                }
                Console.WriteLine();
            }
        }
        public static int Nwd(int x, int y) // <---- zwraca NWD
        {
            int tempValue = Math.Max(x, y);

            y = Math.Min(x, y);
            x = tempValue;
            while (y != 0)
            {
                tempValue = y;
                y = x % y;
                x = tempValue;
            }
            return x;
        }
        private static void RownanieZJednaNiewiadoma(int zmienna, int wynik) // <---- równanie z jedn¹ niewiadom¹ (zmienna * x = wynik)
        {
            int nwd = Nwd(system, zmienna);
            if (wynik % nwd != 0)
            {
                Console.WriteLine("Nie mo¿na rozwi¹zaæ tego równania");
                return;
            }
            int result = (wynik / nwd * ElementOdwrotnyMnozenieInt(zmienna / nwd, nwd)) % (system / nwd);
            Console.WriteLine($"{zmienna} * {result} = {wynik} w {system}, x={result}+{system / nwd}k");
        }
    }

}





