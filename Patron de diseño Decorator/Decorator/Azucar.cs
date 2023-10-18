using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Decorator.Decorator
{
    internal class Azucar : ICafe
    {
        private readonly ICafe cafe;

        public Azucar(ICafe cafe)
        {
            this.cafe = cafe;
        }

        public double CostoCafe()
        {
            return cafe.CostoCafe() + 0.5;
        }

        public string DescripcionCafe()
        {
            return cafe.DescripcionCafe() + ", azucar";
        }
    }
}
