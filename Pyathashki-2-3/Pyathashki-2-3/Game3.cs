using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyathashki_2_3
{
    class Game3 : Game2
    {
         
        public List<int> history = new List<int>();

        public new void Shift(int val)
        {
            base.Shift(val);
            history.Add(val);
        }

        public void StepDown()
        {
            this.Shift(history.Last());
            history.Remove(history.Last());
        }
    }

}
