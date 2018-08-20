using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    class Medicine: Item
    {
        private int HP_Restore;
        private Poke_Status_Enum.Status_Condition Status_Heal;

        public Medicine()
        {

        }

        public int HP_Restore1
        {
            get
            {
                return HP_Restore;
            }

            set
            {
                HP_Restore = value;
            }
        }

        internal Poke_Status_Enum.Status_Condition Status_Heal1
        {
            get
            {
                return Status_Heal;
            }

            set
            {
                Status_Heal = value;
            }
        }
    }
}
