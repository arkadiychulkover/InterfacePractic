using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class PassWordValidate : IValidator
    {
        public string PassWord { get; set; }
        public PassWordValidate(string passWord)
        {
            PassWord = passWord;
        }
        public bool Validate(string str)
        {
            if (str == PassWord)
                return true;
            else
                return false;
        }
    }
}
