using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Prototype.Prototype
{
    internal class Circulo : IFiguraGeometrica
    {
        private double radio;
        private string color;

        public Circulo(double radio,string color)
        {
            this.radio = radio;
            this.color = color;
        }
        public IFiguraGeometrica Clonar()
        {
            return new Circulo(this.radio, this.color);
        }

        public void MostrarCirculo()
        {
            Console.WriteLine($"El radio del Circulo es: {GetRadio()} y el color es: {GetColor()}");
        }

        public double GetRadio()
        {
            return radio;
        }

        public string GetColor()
        {
            return color;
        }
    }
}
