using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class TV : IRemoteControl
    {
        public bool Power { get; set; }
        public int Channel { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
            Power = true;
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
            Power = false;
        }
        public void SetChannel(int channel) 
        {
            Channel = channel;
        }
        public void Show() 
        {
            Console.WriteLine("Channel: " + Channel + "\nIs on: " + Power);
        }
    }
}
