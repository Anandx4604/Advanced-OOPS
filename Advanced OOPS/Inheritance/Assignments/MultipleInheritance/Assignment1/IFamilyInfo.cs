using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface IFamilyInfo : IShowData
    {
        string FatherName { get; set; }
        string MotherName { get; set; }
        string HouseAddress { get; set; }
        int NoOfSiblings { get; set; }

        new string ShowInfo();

    }

}