using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicaciondeFigurasGeometricas
{
    class Circulo:Figura
    {

        private double RadioCir;
        private double AreaCir;
        private double perimetrocir;

        public void PedirDatoCir()
        {

            Console.WriteLine("Introduce  el Radio");
            RadioCir = Convert.ToDouble(Console.ReadLine());

            VisualizarResultadoCir();
        }
        public override double calculararea()
        {

            AreaCir = Math.PI * RadioCir * RadioCir;
            return AreaCir;
        }
        public override double calcularperimetro()
        {

            perimetrocir = 2 * (Math.PI) * RadioCir;
            return perimetrocir;
        }

        public void VisualizarResultadoCir()
        {

            Console.WriteLine("el area del CIRCULO es:" + calculararea());
            Console.WriteLine("El perimetro del CIRCULO es:" + calcularperimetro());
            Console.ReadKey();
        }



    }
}
