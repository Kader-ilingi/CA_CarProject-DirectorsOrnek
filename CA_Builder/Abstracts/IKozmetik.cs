using CA_Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Builder.Abstracts
{
    public interface IKozmetik
    {
        void BuildAdi();
        void BuildFiyat();

        Kozmetik GetKozmetik();
    }
}
