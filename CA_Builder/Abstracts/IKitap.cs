using CA_Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Abstracts
{
    public interface IKitap
    {
        void BuildKitapAdi();
        void BuildKitapYazarAdi();
        void BuildKitapFiyat();

        Kitap GetKitap();
    }
}
