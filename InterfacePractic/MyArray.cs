using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class MyArray : IOutput, IMath, ICalc, IOutout2, ICalc2
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

        public int Greater(int val)
        {
            int c = 0;
            foreach (int it in Arr)
            {
                if (it > val)
                    c++;
            }
            return c;
        }

        public int Less(int val)
        {
            int c = 0;
            foreach (int it in Arr)
            {
                if (it < val)
                    c++;
            }
            return c;
        }

        public void ShowEven()
        {
            foreach (int it in Arr)
            {
                if (it % 2 == 0)
                    Console.WriteLine(it);
            }
        }

        public void ShowOdd()
        {
            foreach (int it in Arr)
            {
                if (it % 2 != 0)
                    Console.WriteLine(it);
            }
        }

        public int CountDistinct()
        {
            int count = 0;
            for (int i = 0; i < Lenght; i++)
            {
                int c = Arr[i];
                int cv = 0;
                for (int j = 0; j < Lenght; j++)
                {
                    if (c == Arr[j])
                        cv++;
                }

                if (cv == 1)
                    count++;
            }
            return count;
        }


        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int it in Arr)
            {
                if (it == valueToCompare)
                    count++;
            }
            return count;
        }
    }
}
