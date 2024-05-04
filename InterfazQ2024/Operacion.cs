using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazQ2024
{
    public class Operacion : IOperacion, IArea
    {
        /// <summary>
        /// Primer número a ingresar
        /// </summary>
        public double N1 { get; set; }

        /// <summary>
        /// Segundo número a ingresar
        /// </summary>
        public double N2 { get; set; }

        public void Imprimir() {
            Console.WriteLine($"La Suma es: {Suma()}");
            Console.WriteLine($"La Resta es: {Resta()}");
            Console.WriteLine($"La Multiplicación es: {Multiplicacion()}");
            Console.WriteLine($"La División es: {Division()}");
            Console.WriteLine($"Area del cuadrado: {Cuadrado()}");
            Console.WriteLine($"Area del triángulo: {Triangulo()}");
        }

        /// <summary>
        /// Calcula el área del cuadrado
        /// </summary>
        /// <returns>Area del cuadrado</returns>
        public double Cuadrado()
        {
            return N1 * N2;
        }

        /// <summary>
        /// Divide dos números
        /// </summary>
        /// <returns>División</returns>
        public double Division()
        {
            return N1 / N2;
        }

        /// <summary>
        /// Multiplica dos números
        /// </summary>
        /// <returns>División</returns>
        public double Multiplicacion()
        {
            return N1 * N2;
        }

        /// <summary>
        /// Resta dos números
        /// </summary>
        /// <returns>Resta</returns>
        public double Resta()
        {
            return N1 - N2;
        }

        /// <summary>
        /// Suma dos números
        /// </summary>
        /// <returns>Suma</returns>
        public double Suma()
        {
            return N1 + N2;
        }

        /// <summary>
        /// Calcula el área del triángulo
        /// </summary>
        /// <returns>Area del triángulo</returns>
        public double Triangulo()
        {
            throw new NotImplementedException();
        }
    }
}
