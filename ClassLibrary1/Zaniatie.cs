// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Zaniatie
    {
        private DateTime Data;
        private Dyscyplina dyscyplina;
        private Sotrydnik sotrydnik;
        private Ayditoria ayditoria;
        private Gryppa gryppa;
        private Para para;
        private VidZaniatia vidZaniatia;

        public Zaniatie(Dyscyplina dyscyplina, Sotrydnik sotrydnik, Ayditoria ayditoria, Gryppa gryppa, Para para, VidZaniatia vidZaniatia)
        {
            this.Data = DateTime.Today;
            this.dyscyplina = dyscyplina;
            this.sotrydnik = sotrydnik;
            this.ayditoria = ayditoria;
            this.gryppa = gryppa;
            this.para = para;
            this.vidZaniatia = vidZaniatia;
        }
    }
}
