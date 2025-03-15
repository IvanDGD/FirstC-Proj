using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal class MyArray : IOutput, IMath, ICalc, IOutput2, ICalc2
    {
        public int Length { get; }
        public int[] Array { get; }

        public MyArray(int length, params int[] array)
        {
            Length = length;
            Array = new int[length];

            int limit = (array.Length < length) ? array.Length : length;
            for (int i = 0; i < limit; i++)
            {
                Array[i] = array[i];
            }
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

        public int Less(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (valueToCompare > Array[i])
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (valueToCompare < Array[i])
                {
                    count++;
                }
            }
            return count;
        }

        public void ShowEven()
        {
            for (int i = 0; i < Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    Console.Write(Array[i]);
                }
            }
            Console.Write("\n");
        }

        public void ShowOdd()
        {
            for (int i = 0; i < Length; i++)
            {
                if (!(Array[i] % 2 == 0))
                {
                    Console.Write(Array[i]);
                }
            }
            Console.Write("\n");
        }

        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    count++;
                }
            }

            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0; 
            for (int i = 0; i < Length; i++)
            {
                if (Array[i] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
