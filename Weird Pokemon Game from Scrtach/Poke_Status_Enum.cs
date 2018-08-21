using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    //this class is in charge of the different status effects that may plague the pokemon during battle (sometimes outside of it as well)
    class Poke_Status_Enum
    {
        public enum Continuous_Status_Condition
        {
            Normal,
            Sleep,
            Posion,
            Burn,
            Freeze,
            Paralysis
        }

        public enum Battle_Status_Condition
        {
            Normal, //No Status condition
            Bound, //"Can't escape"
            Confusion, //"it hurt itself in its cunfusion!"
            Curse, //"The Pokemon Is afflicted By the Curse!"
            Embargo, //
            Encore,
            Flinch,
            Heal_Block,
            Infatuation,
            Identified,
            Leech_Seed,
            Nightmare,
            Perish_Song,
            Spooked,
            Taunt,
            Telekinesis,
            Torment
        }
    }
}
