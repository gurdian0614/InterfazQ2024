using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazQ2024
{
    public interface IOperacion
    {
        /// <summary>
        /// Suma de números
        /// </summary>
        /// <returns>Total sumado de números</returns>
        public double Suma();

        /// <summary>
        /// Resta de números
        /// </summary>
        /// <returns>Total restado de números</returns>
        public double Resta();

        /// <summary>
        /// Multiplicación de números
        /// </summary>
        /// <returns>Total multiplicado de números</returns>
        public double Multiplicacion();

        /// <summary>
        /// División de números
        /// </summary>
        /// <returns>Total dividido de números</returns>
        public double Division();
    }
}
