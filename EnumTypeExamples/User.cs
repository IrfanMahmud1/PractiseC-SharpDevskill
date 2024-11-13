using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTypeExamples
{
    public class User
    {
        public string Password { get; set; }
        public string Name { get; set; }

        public AccountType _AccountType { get; set; }
    }
}
