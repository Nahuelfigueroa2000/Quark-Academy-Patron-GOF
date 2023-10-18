﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_De_Diseño_Abstract_Factory.Abstract_Factory
{
    internal abstract class FabricaDeVehiculos
    {
        public abstract void CrearAutomovil();
        public abstract void CrearMoto();
    }
}
