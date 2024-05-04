using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazQ2024
{
    public interface IArea
    {
        /// <summary>
        /// Implementa el proceso de calcular el área del cuadrado
        /// </summary>
        /// <returns>Area del cuadrado</returns>
        public double Cuadrado();

        /// <summary>
        /// Implementa el proceso de calcular el área del triángulo
        /// </summary>
        /// <returns>Area del triángulo</returns>
        public double Triangulo();
    }
}
