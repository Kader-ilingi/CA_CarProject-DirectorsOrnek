using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.Abstracts
{
    public interface IAbstractFactory
    {
        IEngine CreateEngine();
        ITire CreateTire();
    }
}
