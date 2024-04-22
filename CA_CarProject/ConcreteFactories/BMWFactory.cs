using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.ConcreteFactories
{
    public class BMWFactory : IAbstractFactory
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
