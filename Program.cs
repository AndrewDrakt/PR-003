namespace Практическая_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует интерфейс программы \"Пианино\". Переключение между октавами - F7 и F8");
            ConsoleKeyInfo oktava = Console.ReadKey();
            //И = &&
            //ИЛИ = ||
            if (oktava.Key == ConsoleKey.F8)
            {
                Console.WriteLine("Выбрана 8 октава");
                double[] okt8 = new double[12]
                {4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902};
                ConsoleKeyInfo okt = Console.ReadKey();
                while (okt.Key != ConsoleKey.F7)
                {
                    if (okt.Key == ConsoleKey.A)
                    {
                        Console.Beep(4186, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.S)
                    {
                        Console.Beep(4435, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.D)
                    {
                        Console.Beep(4699, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.F)
                    {
                        Console.Beep(4978, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.G)
                    {
                        Console.Beep(5274, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.H)
                    {
                        Console.Beep(5588, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.J)
                    {
                        Console.Beep(5920, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.K)
                    {
                        Console.Beep(6272, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.L)
                    {
                        Console.Beep(6645, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.O)
                    {
                        Console.Beep(7040, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.P)
                    {
                        Console.Beep(7459, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else if (okt.Key == ConsoleKey.I)
                    {
                        Console.Beep(7902, 100);
                        Console.Clear();
                        okt = Console.ReadKey();
                    }
                    else
                    {
                       break;
                    }
                }
            }
            else 
             {
                
                Console.WriteLine("Выбрана 7 октава");
                double[] okt7 = new double[12]
                {2093,2217,2349,2489 ,2637,2794, 2960, 3136, 3322, 3520 ,3729 , 3951};
                ConsoleKeyInfo okt2 = Console.ReadKey();
                while (okt2.Key != ConsoleKey.F8)
                {
                    
                    if (okt2.Key == ConsoleKey.A)
                    {
                        Console.Beep(2093, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.S)
                    {
                        Console.Beep(2217, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();

                    }
                    else if (okt2.Key == ConsoleKey.D)
                    {
                        Console.Beep(2349, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.F)
                    {
                        Console.Beep(2489, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.G)
                    {
                        Console.Beep(2637, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.H)
                    {
                        Console.Beep(2794, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.J)
                    {
                        Console.Beep(2960, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.K)
                    {
                        Console.Beep(3136, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.L)
                    {
                        Console.Beep(3322, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.O)
                    {
                        Console.Beep(3520, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.P)
                    {
                        Console.Beep(3729, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else if (okt2.Key == ConsoleKey.I)
                    {
                        Console.Beep(3951, 100);
                        Console.Clear();
                        okt2 = Console.ReadKey();
                    }
                    else
                    {
                        break;
                    }
                }
             }
         
        }

    }
} 