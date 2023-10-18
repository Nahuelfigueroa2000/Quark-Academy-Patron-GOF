using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_De_Diseño_Abstract_Factory.Abstract_Factory
{
    internal class FabricaAutomoviles : FabricaDeVehiculos
    {
        
        public override void CrearAutomovil()
        {
            Auto automovil = new Auto();
            automovil.InformacionAuto();
        }

        public override void CrearMoto()
        {
           // no crea motos
        }
    }
}
