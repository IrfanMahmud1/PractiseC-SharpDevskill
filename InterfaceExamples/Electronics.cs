using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    internal class Electronics : ILaptop
    {
        double IProduct.CalculateCustomerSalary()
        {
            throw new NotImplementedException();
        }
    }
}
