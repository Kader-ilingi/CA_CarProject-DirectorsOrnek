using CA_Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Abstracts
{
    public interface IElektronik
    {
        void BuildElektronikUrunAd();
        void BuildElektronikUrunFiyat();

        Elektronik GetElektronik();
    }
}
