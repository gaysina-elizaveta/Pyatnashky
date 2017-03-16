using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyathashki_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var game = new Game(Reader.read("C:\\Лизон\\Пятнашки.txt"));
                while (!game.YouAreWinner())
                {
                    Print.print(game);
                    try
                    {
                        Console.WriteLine("Вdедите число, которое нужно переместить");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        while (!game.Shift(choise))
                        {
                            Console.WriteLine("Введите другое число");
                            choise = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Console.Clear();
                }
                Print.print(game);

            }
            catch (Exception)
            {
                Console.WriteLine("Создание игры невозможно");
            }
            Console.Read();
        }
    }

}
    

