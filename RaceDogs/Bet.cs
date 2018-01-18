using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDogs
{
    class Bet
    {
        public int amount;
        public int dog;
        public Guy bettor;

        public string GetDescription()
        {
            //todo
            return "";
        }
        public int PayOut(int winner)
        {
            
            if (this.dog == winner)
            {
                return this.amount;
            }
            else
            {
                return -(this.amount);
            }
        }
    }
}
