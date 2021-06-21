using System;
using System.Collections.Generic;
using System.Text;

namespace Ajira.ProblemOfKing.Constants
{
    public class AdvantageEnum
    {
        public enum Militia
        { 
           spearmen = -1,
           lightcavalry = -2
           
        }

        public enum Spearmen
        { 
          lightcavalry = -1,
          heavycavalry = -2
        }

        public enum LightCavalry
        { 
          militia =-1,
          footarcher = -2,
          lightcavalry = -3
        }

        public enum CavalryArcher
        { 
          spearmen = -1,
          heavycavalry = -2
        }

        public enum FootArcher
        { 
          militia = -1, 
          footarcher =-2
        }
    }
}
