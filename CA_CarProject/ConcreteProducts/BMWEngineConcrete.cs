using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.ConcreteProducts
{
    public class BMWEngineConcrete : IEngine
    {
        public void Start()
        {
            Console.WriteLine("BMW motoru çalıştırıldı");
        }
    }
}
