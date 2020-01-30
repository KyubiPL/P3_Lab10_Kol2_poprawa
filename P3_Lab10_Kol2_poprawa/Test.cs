using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Lab10_Kol2_poprawa
{
    public class Test
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool Powodzenie { get; set; }
        public string Tester { get; set; }

        public Test(int idi, string naz, string op, bool pow, string tes)
        {
            ID = idi;
            Nazwa = naz;
            Opis = op;
            Powodzenie = pow;
            Tester = tes;
        }

        public void Deconstruct(out int idi, out bool pow)
        {
            idi = ID;
            pow = Powodzenie;
        }

        public void Deconstruct(out int idi,out string naz,out string op,out bool pow,out string tes)
        {
            idi = ID;
            naz = Nazwa;
            op = Opis;
            pow = Powodzenie;
            tes = Tester;
        }
    }
}
