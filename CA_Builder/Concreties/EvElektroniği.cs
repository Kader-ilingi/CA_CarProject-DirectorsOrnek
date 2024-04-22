using CA_Builder.Abstracts;
using CA_Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Concreties
{
    public class EvElektroniği : IElektronik
    {
        private Elektronik _elektronik=new Elektronik();
        public void BuildElektronikUrunAd()
        {
            _elektronik.ElektronikUrunAdi="Televizyon";
        }

        public void BuildElektronikUrunFiyat()
        {
            _elektronik.ElektronikUrunFiyat=3455;
        }

        public Elektronik GetElektronik()
        {
            return _elektronik;
        }
    }
}
