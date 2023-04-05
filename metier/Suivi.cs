using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class Suivi : Categorie
    {
        private readonly string id;
        private readonly string libelle;

        public Suivi(string id, string libelle) : base(id, libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public new string Id { get => id; }
        public new string Libelle { get => libelle; }
    }
}
