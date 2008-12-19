using System;
using System.Collections.Generic;
using System.Text;

namespace A2
{
    partial class Komplex
    {
        protected int real;
        protected int imag;

        public static bool displayExponential = false;

        public Komplex(int real, int imag)
        {
            this.Real = real;
            this.Imag = imag;
        }

        public Komplex(string real, string imag)
        {
            this.Real = int.Parse(real);
            this.Imag = int.Parse(imag);
        }

        protected int Real
        {
            get { return this.real; }
            set { this.real = value; }
        }

        protected int Imag
        {
            get { return this.imag; }
            set { this.imag = value; }
        }

        protected static Komplex Add(Komplex z1, Komplex z2)
        {
            int real = z1.Real + z2.Real;
            int imag = z1.Imag + z2.Imag;

            return new Komplex(real, imag);
        }

        protected static Komplex Sub(Komplex z1, Komplex z2)
        {
            int real = z1.Real - z2.Real;
            int imag = z1.Imag - z2.Imag;

            return new Komplex(real, imag);
        }

        protected static Komplex Mult(Komplex z1, Komplex z2)
        {
            int real = z1.Real * z2.Real - z1.Imag * z2.Imag;
            int imag = z1.Real * z2.Imag + z1.Imag * z2.Real;

            return new Komplex(real, imag);
        }

        protected static Komplex Div(Komplex z1, Komplex z2)
        {
            int real = (z1.Real * z2.Real + z1.Imag * z2.Imag) / (z2.Real * z2.Real + z2.Imag * z2.Imag);
            int imag = (z1.Imag * z2.Real - z1.Real * z2.Imag) / (z2.Real * z2.Real + z2.Imag * z2.Imag);

            return new Komplex(real, imag);
        }

        public override string ToString()
        {
            if (Komplex.displayExponential)
                return this.toStringExponential();
            else
                return this.toStringKartesisch();
        }

        protected string toStringKartesisch()
        {
            return this.Real + " + " + this.Imag + "*i";
        }

        protected string toStringExponential()
        {
            double r, phi;
            r = Math.Sqrt(Math.Pow(this.Imag, 2) + Math.Pow(this.Real, 2));
            phi = Math.Acos(this.Imag / r);

            return r + " * " + "exp(i " + phi + ")";
        }
    }
}
