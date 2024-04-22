using CA_Builder.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Direktors
{
    public class DirectorKitap
    {
        public void Construct(IKitap builder)
        {
            builder.BuildKitapAdi();
            builder.BuildKitapYazarAdi();
            builder.BuildKitapFiyat();
        }
    }
}
