using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Decorator.Decorator
{
    internal class CafeConLeche : ICafe
    {
        private readonly ICafe cafe;

        public CafeConLeche(ICafe cafe)
        {
            this.cafe = cafe;
        }   

        public double CostoCafe()
        {
            return cafe.CostoCafe() + 1;
        }

        public string DescripcionCafe()
        {
            return cafe.DescripcionCafe() + ", leche";
        }
    }
}
