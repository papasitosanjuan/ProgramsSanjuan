using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicaciondeFigurasGeometricas
{
    abstract class Figura
    {
        public string NomFigura;

        public abstract double calculararea();

        public abstract double calcularperimetro();
    }
}
