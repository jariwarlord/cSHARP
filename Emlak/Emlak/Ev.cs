using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak
{
    internal class Ev
    {
        string _il;
        string _ilçe;
        string _adres;
        string _isitma;
        int _katsayisi;

        string il
        {
            get { return il.ToUpper(); }
            set { _il = value; }
        }
        string ilçe
        {
            get { return ilçe.ToUpper(); }
            set { _ilçe = value; }
        }
        string adres
        {
            get { return adres.ToUpper(); }
            set { _adres = value; }
        }
        string isitma
        {
            get { return isitma; }
            set { _isitma = value; }
        }
    }
    class Satılık : Ev
    {
        int KrediCekmeTutari = 400000;
    }
    class Kiralık : Ev
    {
        int Depozito = 3500;
    }
}
