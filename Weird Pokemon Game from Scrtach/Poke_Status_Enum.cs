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
            Normal,   //No Status condition
            Sleep,    //"The Pokemon is fast asleep!"
            Poison,   //"The Pokemon is hurt by poison!"
            Burn,     //"The Pokemon is hurt by its burn!"
            Freeze,   //"The Pokemon is frozen solid!"
            Paralysis //"The Pokemon is paralyzed! it can't move!"
        }

        public enum Battle_Status_Condition
        {
            Normal,    //No Status condition
            Bound,     //"Can't escape"
            Confusion, //"it hurt itself in its cunfusion!"
            Curse,     //"The Pokemon Is afflicted By the Curse!"
            Embargo,   //"The Pokemon can't use items anymore!"
            Encore,    //"The Pokemon got an ENCORE!"
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
