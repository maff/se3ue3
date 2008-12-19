using System;
using System.Collections.Generic;
using System.Text;

namespace A2
{
    partial class Komplex
    {
        public static Komplex operator +(Komplex z1, Komplex z2)
        {
            return Komplex.Add(z1, z2);
        }

        public static Komplex operator -(Komplex z1, Komplex z2)
        {
            return Komplex.Sub(z1, z2);
        }

        public static Komplex operator *(Komplex z1, Komplex z2)
        {
            return Komplex.Mult(z1, z2);
        }

        public static Komplex operator /(Komplex z1, Komplex z2)
        {
            return Komplex.Div(z1, z2);
        }
    }
}
