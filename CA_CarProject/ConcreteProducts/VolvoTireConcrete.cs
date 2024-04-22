using CA_CarProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CarProject.ConcreteProducts
{
    public class VolvoTireConcrete : ITire
    {
        public void Inflate()
        {
            Console.WriteLine("Volvo lastikleri şişiriliyor.");
        }
    }
}
