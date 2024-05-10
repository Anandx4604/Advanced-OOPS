using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMarkDetails
    {
        //only prop and method declaration are allowed
        //By default access modifer is public

        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3{ get; set; }
        void GetMarks(int marks1,int marks2,int marks3);
    }
}