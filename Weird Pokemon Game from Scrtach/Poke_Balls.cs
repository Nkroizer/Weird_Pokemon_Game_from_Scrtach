using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    class Poke_Balls : Item
    {
        private decimal Catch_Rate;

        private string Secondary_effect;

        public Poke_Balls()
        {
            
        }

        public decimal Catch_Rate1
        {
            get
            {
                return Catch_Rate;
            }

            set
            {
                Catch_Rate = value;
            }
        }

        public string Secondary_effect1
        {
            get
            {
                return Secondary_effect;
            }

            set
            {
                Secondary_effect = value;
            }
        }
    }
}
