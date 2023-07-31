using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class LemonadeRecipe
    {
        public int LemonsPerPitcher { get; set; }
        public int SugarCubesPerPitcher { get; set; }
        public int IceCubesPerPitcher { get; set; }
        public int CupsPerPitcher { get; set; }
        public LemonadeRecipe()
        {
            LemonsPerPitcher = 1;
            SugarCubesPerPitcher = 3;
            IceCubesPerPitcher = 3;
            CupsPerPitcher = 5;
        }

    }
}
