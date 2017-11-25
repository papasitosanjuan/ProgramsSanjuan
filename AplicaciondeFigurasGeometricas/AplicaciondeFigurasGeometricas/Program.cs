using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicaciondeFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Calcular Areas de Figuras");
            Console.WriteLine("1.- Triangulo");
            Console.WriteLine("2.- Rectangulo");
            Console.WriteLine("3.- Circulo");
            Console.WriteLine("4.- Salir");
            Console.WriteLine();
            Console.WriteLine("Opcion:");
            opcion=Convert.ToInt32(Console.ReadLine());   //#READKEY LEE CODIGO ASCI #readline lee lo que viene del teclado

            switch(opcion) 
            { 
                case 1:
                  Triangulo mytriangulo = new Triangulo();
                  mytriangulo.PerdirDatoTri();
                  break;
                case 2:
                  Rectangulo myrectangulo = new Rectangulo();
                  myrectangulo.PerdirDatoRec();
                  break;
                case 3:
                  Circulo mycirculo = new Circulo();
                  mycirculo.PedirDatoCir();
                  break;
                case 4:
                  break;
            }

           
        }
    }
}
