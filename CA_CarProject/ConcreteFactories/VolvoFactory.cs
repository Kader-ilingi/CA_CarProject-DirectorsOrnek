using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.ConcreteFactories
{
    public class VolvoFactory : IAbstractFactory
    {
        public IEngine CreateEngine()
        {
            throw new NotImplementedException();
        }

        public ITire CreateTire()
        {
            throw new NotImplementedException();
        }
    }
}
