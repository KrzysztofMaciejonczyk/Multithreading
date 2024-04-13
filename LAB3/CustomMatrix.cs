using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("ThreadVsParallelGUI"), InternalsVisibleTo("ImageParalleling")]
namespace LAB3
{
    internal class CustomMatrix
    {
        private int _size;
        private int[,] _values;

        public CustomMatrix(int size)
        {
            _size = size;
            _values = new int[size,size];
            createMatrix();
        }
        public void createMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _values[i,j] = r.Next(1, 10);
                }
            }
        }
        public void zeroMatrix()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _values[i, j] = 0;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    str.Append(_values[i,j]+" ");
                }
                str.Append(System.Environment.NewLine);
            }
            return str.ToString();
        }
        public static CustomMatrix operator *(CustomMatrix matrix1, CustomMatrix matrix2)
        {
            int rows1 = matrix1._values.GetLength(0);
            int cols1 = matrix1._values.GetLength(1);
            int rows2 = matrix2._values.GetLength(0);
            int cols2 = matrix2._values.GetLength(1);

            if (cols1 != rows2)
            {
                throw new InvalidOperationException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
            }
            CustomMatrix result = new CustomMatrix(rows1);
            int[,] results = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        results[i, j] += matrix1._values[i, k] * matrix2._values[k, j];
                    }
                }
            }
            result._values = results;

            return result;
        }
        public int getSize()
        {
            return _size;
        }
        public int[,] getValues()
        {
            return _values;
        }
        
    }
}
