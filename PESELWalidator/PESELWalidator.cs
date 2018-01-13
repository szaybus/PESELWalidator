using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESELWalidator
{
    public class Walidator
    {
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected int[] pesel = new int[11];

        public Walidator(String pesel) {
            
            WczytajPesel(pesel);
        }

        public void WczytajPesel(String pesel) {
            for (int i = 0; i < 11; i++) {
                this.pesel[i] = (int)Char.GetNumericValue(pesel[i]);
            }
        }

        public int SumaKontrolna() {
            int suma = 0;
            for (int i = 0; i < wagi.Length; i++) {
                suma += pesel[i] * wagi[i];
            }
            suma = 10 - (suma % 10);
            return suma;
        }

        public String DataUrodzenia() {
            int dzien = pesel[4] * 10 + pesel[5];
            int miesiac = pesel[2] * 10 + pesel[3];
            int rok = 1900;
            if(miesiac > 12) {
                //dodatkowo zakodowany rok
                if (miesiac > 80) rok = 1800;
                if (miesiac > 20 && miesiac < 40) rok = 2000;
                if (miesiac > 40 && miesiac < 60) rok = 2100;
                if (miesiac > 60 && miesiac < 80) rok = 2200;
                miesiac %= 20;
            }
            rok += pesel[0] * 10 + pesel[1];
            string data = dzien.ToString("00") + miesiac.ToString("00") + rok.ToString();
            return data;
        }

        public String Plec() {
            if (pesel[9] % 2 == 0) return "K";
            else return "M";
        }

        public Boolean SprawdzPesel() {
            if (pesel[10] == SumaKontrolna()) return true;
            else return false;
        }
    }
}
