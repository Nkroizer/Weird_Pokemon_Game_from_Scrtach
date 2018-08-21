using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Pokemon_Game_from_Scrtach
{
    class Item
    {
        private string Name;
        private int Price;
        private int Sell_For;
        private string Description;

        public Item()
        {

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

        public int Price1
        {
            get
            {
                return Price;
            }

            set
            {
                Price = value;
            }
        }

        public int Sell_For1
        {
            get
            {
                return Sell_For;
            }

            set
            {
                Sell_For = value;
            }
        }

        public string Description1
        {
            get
            {
                return Description;
            }

            set
            {
                Description = value;
            }
        }
    }
}
