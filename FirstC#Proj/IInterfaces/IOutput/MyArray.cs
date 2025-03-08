using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal class MyArray : IOutput, IMath
    {
        private int Length { set; get; } = 0;
        private int[] Array { set; get; } = new int[0];

        public MyArray(int length)
        {
            Length = length;
            Array = new int[length];
        }


        public void Show()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Array[i]);
            }
            Console.Write("\n");
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public int Max()
        {
            int max = Array[0];
            for (int i = 1; i < Length; i++)
            {
                if (Array[i] > max)
                    max = Array[i];
            }
            return max;
        }

        public int Min()
        {
            int min = Array[0];
            for (int i = 1; i < Length; i++)
            {
                if (Array[i] < min)
                    min = Array[i];
            }
            return min;
        }

        public float Avg()
        {
            float result = 0;
            for (int i = 0; i < Length; i++)
            {
                result += Array[i];
            }
            result /= Length;
            return result;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Array[i] == valueToSearch)
                    return true;
            }
            return false;
        }
    }
}
