using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Projet_
{
    internal class Type
    {
        private int NoType;
        private string LettreCategorie;
        private string Libelle;

        public Type(int NoType, string LettreCategorie, string Libelle) 
        { 
            this.NoType = NoType;
            this.LettreCategorie = LettreCategorie;
            this.Libelle = Libelle;
        }

        public int GetNoType()
        {
            return NoType;
        }

        public string GetLettreCategorie()
        {
            return LettreCategorie;
        }

        public string GetLibelle()
        {
            return Libelle;
        }

        public override string ToString()
        {
            return LettreCategorie + NoType + "-" + Libelle; 
        }
    }
}
