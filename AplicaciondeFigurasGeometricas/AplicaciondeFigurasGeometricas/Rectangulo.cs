using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicaciondeFigurasGeometricas
{
    class Rectangulo:Figura
    {
        private double BaseRec;
        private double AlturaRec;
        private double AreaRec;
        private double perimetrorec;

        public void PerdirDatoRec()
        {

            Console.WriteLine("Introduce la base del Rectangulo");
            BaseRec = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la Altura del Rectangulo");
            AlturaRec = Convert.ToDouble(Console.ReadLine());

            VisualizarResultadoRec();
        }

        public override double calculararea()
        {

            AreaRec = BaseRec * AlturaRec;
            return AreaRec;
        }
        public override double calcularperimetro()
        {

            perimetrorec = (BaseRec + BaseRec)+(AlturaRec + AlturaRec);
            return perimetrorec;
        }

        public void VisualizarResultadoRec()
        {

            Console.WriteLine("El area del RECTANGULO es:" + calculararea());
            Console.WriteLine("El perimetro del RECTANGULO es:" + calcularperimetro());
            Console.ReadKey();
        }

    }
}
