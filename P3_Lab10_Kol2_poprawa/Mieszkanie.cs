using System;
using System.Collections.Generic;
using System.Text;


namespace P3_Lab10_Kol2_poprawa
{
    public class Mieszkanie
    {
        public int Metraz;
        public string Nazwa;
        public int OdlegloscOdCentrum;

        public Mieszkanie(int Metraz, string Nazwa, int OdlegloscOdCentrum)
        {
            this.Metraz = Metraz;
            this.Nazwa = Nazwa;
            this.OdlegloscOdCentrum = OdlegloscOdCentrum;
        }
    }
}
