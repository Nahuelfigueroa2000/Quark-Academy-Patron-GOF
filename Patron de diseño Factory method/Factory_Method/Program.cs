using Patron_de_diseño_Factory_method.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Factory_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactoryDocumento fabrica = new FactoryDocumentoDeTexto();
            IDocumento documento = fabrica.CrearDocumento();

            documento.AbrirDocumento();
            documento.GuardarDocumento();
            documento.CerrarDocumento();
            Console.WriteLine("---------------------");

            IFactoryDocumento fabrica1 = new FactoryHojaDeCalculo();
            IDocumento hojaCalculo= fabrica1.CrearDocumento();

            hojaCalculo.AbrirDocumento();
            hojaCalculo.GuardarDocumento();
            hojaCalculo.CerrarDocumento();
            Console.WriteLine("---------------------");

            IFactoryDocumento fabrica2 = new FactoryPresentancion();
            IDocumento presentacion = fabrica2.CrearDocumento();

            presentacion.AbrirDocumento();
            presentacion.GuardarDocumento();
            presentacion.CerrarDocumento();

            Console.ReadKey();
        
        }
    }
}
