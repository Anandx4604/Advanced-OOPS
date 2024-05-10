using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance
{
    public interface IMarkDetails
    {
        int Mark1 { get; set; }
        int Mark2 { get; set; }
        int Mark3 { get; set; }
        void GetMarks();
    }
}