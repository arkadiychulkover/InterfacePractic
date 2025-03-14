using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class Radio : IRemoteControl
    {
        public bool Power { get; set; }
        public int Volna { get; set; }
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
            Volna = channel;
        }
        public void Show()
        {
            Console.WriteLine("Volna: " + Volna + "\nIs on: " + Power);
        }
    }
}
