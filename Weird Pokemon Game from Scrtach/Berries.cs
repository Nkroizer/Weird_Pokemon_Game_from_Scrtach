using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    /*This Class is in charge of the Berries, Berries are the 'Fruits' in the Pokemon world, 
     * they can be planted and they can be used for status healing or restoring HP */
    class Berries : Item
    {
        private int Serial_Number; //the berries serial number
        private string Effect; //what effect the berry has (e.g. status heal or HP restor etc.)
        private int HP_Restore; //if it restores HP, How Much does it heal
        private Poke_Status_Enum.Continuous_Status_Condition Status_Cure; //if it cures a status condition, which status does it heal

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

        public string Effect1
        {
            get
            {
                return Effect;
            }

            set
            {
                Effect = value;
            }
        }

        internal Poke_Status_Enum.Continuous_Status_Condition Status_Cure1
        {
            get
            {
                return Status_Cure;
            }

            set
            {
                Status_Cure = value;
            }
        }

        public Berries()
        {

        }
    }
}
