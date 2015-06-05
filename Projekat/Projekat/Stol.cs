using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class Stol
    {
        enum oblikStola{Pravougaonik, Krug, Kvadrat};

        int koordinataX;

        public int KoordinataX
        {
            get { return koordinataX; }
            set { koordinataX = value; }
        }

        int koordinataY;

        public int KoordinataY
        {
            get { return koordinataY; }
            set { koordinataY = value; }
        } 
    }
}
