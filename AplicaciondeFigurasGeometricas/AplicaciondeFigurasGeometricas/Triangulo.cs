using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicaciondeFigurasGeometricas
{
    class Triangulo:Figura
    {
        private double BaseTri;
        private double AlturaTri;
        private double AreaTri;
        private double perimetrotri;

        public void PerdirDatoTri(){
           
            Console.WriteLine("Introduce la base del triangulo");
            BaseTri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la Altura del triangulo");
            AlturaTri = Convert.ToDouble(Console.ReadLine());

            VisualizarResultadoTri();
            }

        public override double calculararea(){
    
            AreaTri = BaseTri * AlturaTri / 2;
            return AreaTri;
            }
        public override double calcularperimetro()
        {

            perimetrotri = BaseTri + BaseTri + BaseTri;
            return perimetrotri;
        }
        public void VisualizarResultadoTri() {

            Console.WriteLine("El area del triangulo es:" + calculararea());
            Console.WriteLine("El perimetro del triangulo es:" + calcularperimetro());
            Console.ReadKey();
        }
    
    }
}
