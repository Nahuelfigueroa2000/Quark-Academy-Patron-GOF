using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Visitor.Visitor
{
    internal interface IAnimalVisitor
    {
        void VisitarPerro(Perro perro);
        void VisitarGato(Gato gato);
        void VisitarPato(Pato pato);
    }
}
