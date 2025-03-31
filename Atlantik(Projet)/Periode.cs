using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Projet_
{
    internal class Periode
    {
        private int NoPeriode;
        private string DateDebut;
        private string DateFin;

        public Periode(int NoPeriode, string DateDebut, string DateFin)
        {
            this.NoPeriode = NoPeriode;
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
        }

        public int GetNoPeriode()
        {             
            return NoPeriode;          
        }

        public string GetDateDebut()
        {

            return DateDebut;
        }

        public string GetDateFin()
        {
            return DateFin;
        }

        public override string ToString()
        {
            return DateDebut + "-" + DateFin;
        }
    }
}
