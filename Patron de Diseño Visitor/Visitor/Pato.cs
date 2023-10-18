﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Visitor.Visitor
{
    internal class Pato : IAnimalVisitable
    {
        public void Aceptar(IAnimalVisitor visitor)
        {
            visitor.VisitarPato(this);
        }
    }
}
