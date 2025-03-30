using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Matrix
    {

        private int[,] _arr;

        public int Rows { get; set; }
        public int Cols { get; set; }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            _arr = new int[rows, cols];
        }

        public override bool Equals(object? obj)
        {
            return obj != null && this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + Rows;
            hash = hash * 31 + Cols;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    hash = hash * 31 + _arr[i, j];
                }
            }
            return hash;
        }


        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result._arr[i, j] = matrix1._arr[i, j] + matrix2._arr[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result._arr[i, j] = matrix1._arr[i, j] - matrix2._arr[i, j];
                }
            }
            return result;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2)) return true;
            if (matrix1 is null || matrix2 is null) return false;
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols) return false;

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    if (matrix1._arr[i, j] != matrix2._arr[i, j])
                        return false; 
                }
            }
            return true;
        }
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    sb.Append(_arr[i, j] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
