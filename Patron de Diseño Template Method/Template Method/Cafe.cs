using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Template_Method.Template_Method
{
    internal abstract class Cafe
    {
        public void PrepararCafe()
        {
            CalentarAgua();
            MoldearCafe();
            ServirEnTaza();
            AgregarExtras();
        }
        private void CalentarAgua()
        {
            Console.WriteLine("Calentando agua");
        }

        private void ServirEnTaza()
        {
            Console.WriteLine("Sirviendo en una taza");
        }

        protected abstract void MoldearCafe();
        protected abstract void AgregarExtras();
    }
}
