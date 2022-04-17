using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    /// <summary>
    /// Interface for calculation strategies.
    /// </summary>
    internal interface ICalculate
    {
        /// <summary>
        /// Perform calculation
        /// </summary>
        /// <param name="order">Order object.</param>
        void DoAlgorithm();

        double GetResult();
    }
}
