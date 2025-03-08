using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class MyArray : IOutput, IMath
    {
        int Lenght { get; set; }
        int[] Arr;

        public MyArray(int lenght) { 
            Lenght = lenght;
            Arr = new int[Lenght];
            for (int i = 0; i < Lenght; i++)
                Arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        public void Show() 
        {
            foreach (int it in Arr) 
            {
                Console.WriteLine(it);
            }
            Console.WriteLine();
        }

        public void Show(string mes) 
        {
            foreach (int it in Arr)
            {
                Console.WriteLine(it);
            }
            Console.WriteLine(mes);
        }

        public int Max()
        {
            int max = 0;
            foreach (int it in Arr) 
            {
                if(max < it)
                    max = it;
            }
            return max;
        }

        public int Min()
        {
            int min = 0;
            foreach (int it in Arr)
            {
                if (min > it)
                    min = it;
            }
            return min;
        }

        public float Avg()
        {
            int Avg = 0;
            foreach (int it in Arr)
            {
                Avg += it;
            }
            return Avg / Lenght;
        }

        public bool Search(int ValueToSearch)
        {
            Array.Sort(Arr);
            return Array.BinarySearch(Arr, ValueToSearch) == -1? false : true;
        }
    }
}
