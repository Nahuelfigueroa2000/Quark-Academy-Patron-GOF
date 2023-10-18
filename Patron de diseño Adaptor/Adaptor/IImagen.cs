using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Adaptor.Adaptor
{
    internal interface IImagen
    {
        void CargarImagen(string archivoNombre);
        void GuardarImagen(string archivoNombre);
    }
}
