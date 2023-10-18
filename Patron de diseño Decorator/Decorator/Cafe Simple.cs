using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Decorator.Decorator
{
    internal class Cafe_Simple : ICafe
    {
        public double CostoCafe()
        {
            return 3;
        }

        public string DescripcionCafe()
        {
            return "Cafe Simple";
        }
    }
}
