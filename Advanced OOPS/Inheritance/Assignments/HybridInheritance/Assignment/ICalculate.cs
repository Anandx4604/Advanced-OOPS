using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public interface ICalculate
    {
        double ProjectMark { get; set; }
        void CalculateUG();
    }
}