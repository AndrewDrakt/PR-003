namespace Практическая_3
{
    internal class Program
    {
        static void MakeSound(int korobka)
        {
            Console.Beep(korobka, 100);
            Console.Clear();
        }
        static void MakeSound2(int korobka1)
        {
            Console.Beep(korobka1, 100);
            Console.Clear();
        }
        static void Main()
        {
            Console.WriteLine("Вас приветсвует интерфейс программы \"Пианино\". Переключение между октавами - F7 и F8");
            ConsoleKeyInfo oktava = Console.ReadKey();
            //И = &&
            //ИЛИ = ||
            if (oktava.Key == ConsoleKey.F8)
            {
                Console.WriteLine("Выбрана 8 октава");
                int[] okt8 = new int[12]
                {4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902};
                ConsoleKeyInfo okt = Console.ReadKey();
                while (okt.Key != ConsoleKey.F7)
                {
                    if (okt.Key == ConsoleKey.A)
                    {
                        MakeSound(okt8[0]);
                    }
                    else if (okt.Key == ConsoleKey.S)
                    {
                        MakeSound(okt8[1]);
                    }
                    else if (okt.Key == ConsoleKey.D)
                    {
                        MakeSound(okt8[2]);
                    }
                    else if (okt.Key == ConsoleKey.F)
                    {
                        MakeSound(okt8[3]);
                    }
                    else if (okt.Key == ConsoleKey.G)
                    {
                        MakeSound(okt8[4]);
                    }
                    else if (okt.Key == ConsoleKey.H)
                    {
                        MakeSound(okt8[5]);
                    }
                    else if (okt.Key == ConsoleKey.J)
                    {
                        MakeSound(okt8[6]);
                    }
                    else if (okt.Key == ConsoleKey.K)
                    {
                        MakeSound(okt8[7]);
                    }
                    else if (okt.Key == ConsoleKey.L)
                    {
                        MakeSound(okt8[8]);
                    }
                    else if (okt.Key == ConsoleKey.O)
                    {
                        MakeSound(okt8[9]);
                    }
                    else if (okt.Key == ConsoleKey.P)
                    {
                        MakeSound(okt8[10]);
                    }
                    else if (okt.Key == ConsoleKey.I)
                    {
                        MakeSound(okt8[11]);
                    }
                    else
                    {
                        break;
                    }
                    okt = Console.ReadKey();
                }
            }
            else if (oktava.Key == ConsoleKey.F7)
            {
                Console.WriteLine("Выбрана 7 октава");
                int[] okt7 = new int[12]
                {2093, 2217, 2349, 2489 , 2637, 2794, 2960, 3136, 3322, 3520 ,3729 , 3951};
                ConsoleKeyInfo okt2 = Console.ReadKey();
                while (okt2.Key != ConsoleKey.F8)
                {
                    if (okt2.Key == ConsoleKey.A)
                    {
                        MakeSound2(okt7[0]);
                    }
                    else if (okt2.Key == ConsoleKey.S)
                    {
                        MakeSound2(okt7[1]);
                    }
                    else if (okt2.Key == ConsoleKey.D)
                    {
                        MakeSound2(okt7[2]);
                    }
                    else if (okt2.Key == ConsoleKey.F)
                    {
                        MakeSound2(okt7[3]);
                    }
                    else if (okt2.Key == ConsoleKey.G)
                    {
                        MakeSound2(okt7[4]);
                    }
                    else if (okt2.Key == ConsoleKey.H)
                    {
                        MakeSound2(okt7[5]);
                    }
                    else if (okt2.Key == ConsoleKey.J)
                    {
                        MakeSound2(okt7[6]);
                    }
                    else if (okt2.Key == ConsoleKey.K)
                    {
                        MakeSound2(okt7[7]);
                    }
                    else if (okt2.Key == ConsoleKey.L)
                    {
                        MakeSound2(okt7[8]);
                    }
                    else if (okt2.Key == ConsoleKey.O)
                    {
                        MakeSound2(okt7[9]);
                    }
                    else if (okt2.Key == ConsoleKey.P)
                    {
                        MakeSound2(okt7[10]);
                    }
                    else if (okt2.Key == ConsoleKey.I)
                    {
                        MakeSound2(okt7[11]);
                    }
                    else
                    {
                        break;
                    }
                    okt2 = Console.ReadKey();
                }
            }
        }
    }
}