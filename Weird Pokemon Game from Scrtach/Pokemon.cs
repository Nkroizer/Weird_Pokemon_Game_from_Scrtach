using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    class Pokemon
    {
        #region Variables
        private uint Pokedex_Number;
        private string Pokémon_category;
        private string Name;
        private decimal Catch_rate;
        private uint Level;
        private uint HP;
        private uint XP;
        private bool Shiny;
        private string Pokedex_Entry;

        private Poke_Type_Enum.type Main_Type;
        private Poke_Type_Enum.type Sub_Type;
        private Poke_Nature_Enum.Nature P_Nature;
        private Poke_Sex_Enum.sex P_Sex;

        private Base_Stats base_stats;

        //undecided attributes
        string Strong_Against;
        string Weak_Against;
        string Ability;
        string Attack1;
        string Attack2;
        string Attack3;
        string Attack4;
        #endregion

        #region Get/Set
        public uint Pokedex_Number1
        {
            get
            {
                return Pokedex_Number;
            }

            set
            {
                Pokedex_Number = value;
            }
        }

        public string Pokémon_category1
        {
            get
            {
                return Pokémon_category;
            }

            set
            {
                Pokémon_category = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public decimal Catch_rate1
        {
            get
            {
                return Catch_rate;
            }

            set
            {
                Catch_rate = value;
            }
        }

        public uint Level1
        {
            get
            {
                return Level;
            }

            set
            {
                Level = value;
            }
        }

        public uint HP1
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

        public uint XP1
        {
            get
            {
                return XP;
            }

            set
            {
                XP = value;
            }
        }

        public bool Shiny1
        {
            get
            {
                return Shiny;
            }

            set
            {
                Shiny = value;
            }
        }

        public string Pokedex_Entry1
        {
            get
            {
                return Pokedex_Entry;
            }

            set
            {
                Pokedex_Entry = value;
            }
        }

        internal Poke_Type_Enum.type Main_Type1
        {
            get
            {
                return Main_Type;
            }

            set
            {
                Main_Type = value;
            }
        }

        internal Poke_Type_Enum.type Sub_Type1
        {
            get
            {
                return Sub_Type;
            }

            set
            {
                Sub_Type = value;
            }
        }

        internal Poke_Nature_Enum.Nature P_Nature1
        {
            get
            {
                return P_Nature;
            }

            set
            {
                P_Nature = value;
            }
        }

        internal Poke_Sex_Enum.sex P_Sex1
        {
            get
            {
                return P_Sex;
            }

            set
            {
                P_Sex = value;
            }
        }

        internal Base_Stats Base_stats
        {
            get
            {
                return base_stats;
            }

            set
            {
                base_stats = value;
            }
        }
        #endregion
    }
}
