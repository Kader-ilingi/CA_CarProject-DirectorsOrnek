using CA_Builder.Abstracts;
using CA_Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Concreties
{
    public class KlasikRoman : IKitap
    {

        private Kitap _kitap=new Kitap();
        public void BuildKitapAdi()
        {
            _kitap.KitapAdi="İnsan ne ile yaşar";
        }

        public void BuildKitapFiyat()
        {
            _kitap.Fiyat=85;
        }

        public void BuildKitapYazarAdi()
        {
            _kitap.YazarAdi="L.N Tolstoy";
        }

        public Kitap GetKitap()
        {
            return _kitap;
        }
    }
}
