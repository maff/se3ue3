using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Feld
    {
        protected int[] zahlen = new int[5];

        public Feld()
        {
        }

        public Feld(int[] values)
        {
            if (values.Length != this.zahlen.Length)
                throw new ArgumentException("Parameter length must match indexer length");

            for (int i = 0; i < values.Length; i++)
                this.zahlen[i] = values[i];
        }

        public int this[int index]
        {
            get
            {
                this.checkIndex(index);
                return zahlen[index];
            }
            set
            {
                this.checkIndex(index);
                zahlen[index] = value;
            }        
        }

        public int Length
        {
            get { return this.zahlen.Length; }
            set { }
        }

        protected void checkIndex(int index)
        {
            if (index < 0 ||
                index >= this.zahlen.Length)
            {
                throw new ArgumentException("Invalid index");
            }
        }

        public static Feld operator +(Feld a, Feld b)
        {
            Feld erg = new Feld();
            for (int i = 0; i < a.Length; i++)
                erg[i] = a[i] + b[i];

            return erg;
        }

        public static Feld operator *(Feld a, Feld b)
        {
            Feld erg = new Feld();
            for (int i = 0; i < a.Length; i++)
                erg[i] = a[i] * b[i];

            return erg;
        }

        public static Feld getRandom(Random rnd)
        {
            Feld feld = new Feld();
            for (int i = 0; i < feld.Length; i++)
                feld[i] = rnd.Next(0, 10);

            return feld;
        }

        public static void print(Feld feld)
        {
            for(int i = 0; i < feld.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i+1, feld[i]);
            }
            Console.WriteLine();
        }
    }
}
