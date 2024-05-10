using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IBrand
    {
        string BrandName { get; set; }
        string ModelName { get; set; }

        string ShowDetails(); 
    }
}