using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
}
