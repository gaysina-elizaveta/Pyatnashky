using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyathashki_2_3
{
    class Game2 : Game
    {
        public bool YouAreWinner()
        {
            bool status = true;
            int[] temper = new int[area_field.Length];
            int temp = 0;
            foreach (var item in area_field)
            {
                temper[temp] = item;
                temp++;
            }
            for (int i = 0; i < temper.Length - 1; i++)
            {
                if ((i != temper.Length - 2) && (temper[i] > temper[i + 1]))
                {
                    status = false;
                }
                if (temper[temper.Length - 1] != 0)
                {
                    status = false;
                }
            }
            return status;
        }


        public void RandomMixer(int[] p)
        {
            int tmp = 0;

            Random gen = new Random();

            for (int i = 0; i < 16; i++)
            {
                bool isExist = false;
                do
                {
                    isExist = false;
                    tmp = gen.Next(0, 16);
                    for (int j = 0; j < i; j++)
                    {
                        if (tmp == p[j]) { isExist = true; }
                    }
                }
                while (isExist);
                p[i] = tmp;
            }
        }
    }
}
