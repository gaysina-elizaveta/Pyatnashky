using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatnashki_1
{
    class Print
    {
        public static void print(Game game)
        {

            for (int i = 0; i < Math.Sqrt(game.area_field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(game.area_field.Length); j++)
                {

                    Console.Write(game.area_field[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
