using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varos
    {
        int id;
        string nev;
        long lakossag;

        public Varos(int id, string nev, long lakossag)
        {
            this.Id = id;
            this.Nev = nev;
            this.Lakossag = lakossag;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public long Lakossag { get => lakossag; set => lakossag = value; }

        public override string ToString()
        {
            return nev+" -Lakossag: "+lakossag+" fő";
        }
    }
}
