using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    //This class is in charge of the base stats of each pokemon (e.g. the base attack and defense each pokemon starts with)
    class Base_Stats
    {
        #region Variables
        private int HP;      //Base Life Points
        private int Attack;  //Base Attack Points
        private int Defense; //Base Defense  Points
        private int Sp_Atk;  //Base Special Attack Points
        private int Sp_Def;  //Base Special Defense Points
        private int Speed;   //Base Speed
        #endregion

        #region Get/Set
        public int HP1
        {
            get
            {
                return HP;
            }

            set
            {
                HP = value;
            }
        }

        public int Attack1
        {
            get
            {
                return Attack;
            }

            set
            {
                Attack = value;
            }
        }

        public int Defense1
        {
            get
            {
                return Defense;
            }

            set
            {
                Defense = value;
            }
        }

        public int Sp_Atk1
        {
            get
            {
                return Sp_Atk;
            }

            set
            {
                Sp_Atk = value;
            }
        }

        public int Sp_Def1
        {
            get
            {
                return Sp_Def;
            }

            set
            {
                Sp_Def = value;
            }
        }

        public int Speed1
        {
            get
            {
                return Speed;
            }

            set
            {
                Speed = value;
            }
        }
        #endregion

        public Base_Stats()
        {

        }
    }
}
