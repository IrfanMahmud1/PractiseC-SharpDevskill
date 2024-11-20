using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
     class Camera : IProduct
    {
        public double CalculateCustomerSalary()
        {
            throw new NotImplementedException();
        }
        public double Calculate()
        {
            return 4;
        }
    }
}
