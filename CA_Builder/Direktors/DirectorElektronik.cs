using CA_Builder.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Direktors
{
    public class DirectorElektronik
    {
        public DirectorElektronik(IElektronik builder)
        {
            builder.BuildElektronikUrunAd();
            builder.BuildElektronikUrunFiyat();

        }
    }
}
