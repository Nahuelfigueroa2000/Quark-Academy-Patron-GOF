using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_De_Diseño_Abstract_Factory.Abstract_Factory
{
    internal class FabricaMotos : FabricaDeVehiculos
    {
        public override void CrearAutomovil()
        {
            // no crea autos
        }

        public override void CrearMoto()
        {
            Moto moto = new Moto();
            moto.InformacionMoto();
        }
    }
}
