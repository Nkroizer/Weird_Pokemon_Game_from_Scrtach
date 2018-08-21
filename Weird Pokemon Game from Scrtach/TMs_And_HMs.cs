using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    class TMs_And_HMs : Item
    {
        private int Serial_Number;
        private Poke_Type_Enum.type P_Type;
        private Attack_Category_Enum.Attack_Category P_Attack;

        public int Serial_Number1
        {
            get
            {
                return Serial_Number;
            }

            set
            {
                Serial_Number = value;
            }
        }

        internal Poke_Type_Enum.type P_Type1
        {
            get
            {
                return P_Type;
            }

            set
            {
                P_Type = value;
            }
        }

        internal Attack_Category_Enum.Attack_Category P_Attack1
        {
            get
            {
                return P_Attack;
            }

            set
            {
                P_Attack = value;
            }
        }

        public TMs_And_HMs()
        {

        }
    }
}
