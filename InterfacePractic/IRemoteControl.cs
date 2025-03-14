using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
}
