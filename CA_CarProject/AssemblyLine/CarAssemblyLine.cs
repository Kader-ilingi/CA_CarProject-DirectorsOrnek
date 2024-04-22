using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.AssemblyLine
{
    public class CarAssemblyLine
    {
        private IAbstractFactory _factory;

        public CarAssemblyLine(IAbstractFactory factory)
        {
            _factory = factory;
        }
        public void AssemblyCar()
        {
            IEngine engine = _factory.CreateEngine();
            ITire tire = _factory.CreateTire();

            Console.WriteLine("Otomobil montajı başlıyor...");
            tire.Inflate();
            engine.Start();
            Console.WriteLine("Otomobil montajı tamamlandı");
        }
    }
}
