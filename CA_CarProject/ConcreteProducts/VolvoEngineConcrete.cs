using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.ConcreteProducts
{
    public class VolvoEngineConcrete : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Volvo motoru çalıştırıyor.");
        }
    }
}
