using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    class Poke_Nature_Enum
    {
        //This class is in charge of the different types of pokemon natures, each nature comes with its own effect on the pokemon's base stat
        public enum Nature
        {
            Hardy,   //No base stat change
            Lonely,  //+Attack,  -Defense
            Brave,   //+Attack,  -Speed
            Adamant, //+Attack,  -Sp. Attack
            Naughty, //+Attack,  -Sp. Defense
            Bold,    //+Defense, -Attack
            Docile,  //No base stat change
            Relaxed, //+Defense, -Speed
            Impish,  //+Defense, -Sp. Attack
            Lax,     //+Defense, -Sp. Defense
            Timid,   //+Speed,   -Attack
            Hasty,   //+Speed,   -Defense
            Serious,
            Jolly,
            Naive,
            Modest,
            Mild,
            Quiet,
            Bashful,
            Rash,
            Calm,
            Gentle,
            Sassy,
            Careful,
            Quirky
        }
    }
}
