using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyathashki_2_3
{
    class Game
    {
        public readonly int[,] area_field;

        private bool ChekOnCreation(int[] gets)
        {
            bool ret = true;
            int gameline = (int)Math.Sqrt(gets.Length);
            if (gameline % 1 == 0)
            {
                int zerocount = 0;
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 1; j < gets.Length; j++)
                    {
                        if (gets[i] == gets[j])
                        {
                            ret = false;
                        }
                    }
                }
                foreach (var item in gets)
                {
                    if (item == 0)
                    {
                        zerocount++;
                    }
                }
                if (zerocount > 1 || zerocount == 0)
                {
                    ret = false;
                }
            }
            else
            {
                ret = false;
            }
            return ret;
        }

        public Game(params int[] gets)
        {

            if (ChekOnCreation(gets))
            {
                int t = 0;
                area_field = new int[Convert.ToInt32(Math.Sqrt(gets.Length)), Convert.ToInt32(Math.Sqrt(gets.Length))];
                for (int i = 0; i < Math.Sqrt(gets.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(gets.Length); j++)
                    {
                        area_field[i, j] = gets[t];
                        t++;
                    }
                }

            }
        }


        public bool Shift(int val)
        {
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;
            for (int i = 0; i < Math.Sqrt(area_field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(area_field.Length); j++)
                {
                    if (area_field[i, j] == 0)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    if (area_field[i, j] == val)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }
            if ((Math.Abs(i2 - i1) + Math.Abs(j2 - j1)) == 1)
            {
                area_field[i1, j1] = val;
                area_field[i2, j2] = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

       

    }
}

