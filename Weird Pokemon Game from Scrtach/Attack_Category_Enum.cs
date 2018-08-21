using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    //This class is in charge of the different attack categories
    class Attack_Category_Enum
    {
        public enum Attack_Category
        {
            Physical, //Attacks that includes actual touch
            Special,  //Attacks that require no physical touch
            Status    //Attacks that effects the users/opponents stats 
        }
    }
}
