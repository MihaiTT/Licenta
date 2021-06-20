using System;
using System.Collections.Generic;
using System.Text;

namespace AplicatieGestiune.BLL
{
    class produseBLL
    {
        public int QR_code { get; set; }
        public string nume_produs { get; set; }
        public int id_furnizor { get; set; }
        public decimal pret_fara_TVA { get; set; }
        public decimal procent_TVA { get; set; }
        public decimal cantitate_stoc { get; set; }
        public string unitate_masura { get; set; }

    }
}
