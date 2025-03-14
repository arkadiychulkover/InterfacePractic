using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class ValidateGmail : IValidator
    {
        public bool Validate(string str)
        {
            if (str.Contains("@gmail.com"))
                return true;
            else
                return false;
        }
    }
}
