using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.ConcreteProducts
{
    public class BMWTireConcrete : ITire
    {
        public void Inflat()
        {
            Console.WriteLine("BMW lastikleri şişirildi");
        }
    }
}
