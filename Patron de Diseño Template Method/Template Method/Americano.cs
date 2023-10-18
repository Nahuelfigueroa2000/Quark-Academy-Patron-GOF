using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Template_Method.Template_Method
{
    internal class Americano : Cafe
    {
        protected override void MoldearCafe()
        {
            Console.WriteLine("Preparando café americano");
        }

        protected override void AgregarExtras()
        {
            Console.WriteLine("Agregando agua caliente adicional");
        }
    }
}
