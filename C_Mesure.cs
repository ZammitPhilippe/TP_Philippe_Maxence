using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Philippe_Maxence
{
    class C_Mesure
    {
        public int ID { get; set;}

        public int X { get; set; }

        public int Y { get; set; }

        public int Hauteur { get; set; }

        public int Largeur { get; set; }

        public override string ToString()
        {
            return $"{ X} || { Y}";
        }
    }
}
