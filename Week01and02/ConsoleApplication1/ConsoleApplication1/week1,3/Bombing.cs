using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bombing
    {
        public static int MatrixBombing(int[,] matrix)
        {
            int x = 0;
            int br = 0;
            int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1) * 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i != 0 && i != matrix.GetLength(0) - 1 && j != 0 && j != matrix.GetLength(1) - 1)
                    {
                        array[br] = Metod1(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }



                    else if (i != 0 && i != matrix.GetLength(0) - 1 && j == 0)
                    {
                        array[br] = Metod2(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }


                    else if (i == 0 && j != 0 && j != matrix.GetLength(1) - 1)
                    {
                        array[br] = Metod3(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }

                    else if (i == 0 && j == 0)
                    {
                        array[br] = Metod4(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }

                    else if (i == matrix.GetLength(0) - 1 && j != 0 && j != matrix.GetLength(1) - 1)
                    {
                        array[br] = Metod5(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;


                    }

                    else if (i != 0 && i != matrix.GetLength(0) - 1 && j == matrix.GetLength(1) - 1)
                    {
                        array[br] = Metod6(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;
                    }

                    else if (i == matrix.GetLength(0) - 1 && j == matrix.GetLength(1) - 1)
                    {
                        array[br] = Metod7(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }

                    else if (i == matrix.GetLength(0) - 1 && j == 0)
                    {
                        array[br] = Metod8(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }

                    else if (i == 0 && j == matrix.GetLength(1) - 1)
                    {
                        array[br] = Metod9(matrix, i, j);
                        array[br + 1] = matrix[i, j];
                        br += 2;

                    }

                }
            }
            int n = 0;
            for (int i = 0; i < array.Length - 1; i = i + 2)
            {

                if (array[i] > x)
                {
                    x = array[i];
                    n = array[i + 1];
                }
            }
            Console.WriteLine("{0} - the damage if we bomb at {1}", x, n);
            return x;
        }
        public static int Metod1(int[,] matrix, int i, int j)
        {
            int p = 0;
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        p += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        p = p + matrix[i, j];
                }
            }
            return p;
        }
        public static int Metod2(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j; l <= j + 1; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
        public static int Metod3(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
        public static int Metod4(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i; k <= i + 1; k++)
            {
                for (int l = j; l <= j + 1; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;

        }
        public static int Metod5(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i - 1; k <= i; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
        public static int Metod6(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
        public static int Metod7(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i - 1; k <= i; k++)
            {
                for (int l = j - 1; l <= j; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
        public static int Metod8(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i - 1; k <= i; k++)
            {
                for (int l = j; l <= j + 1; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
        public static int Metod9(int[,] matrix, int i, int j)
        {
            int x = 0;
            for (int k = i; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j; l++)
                {
                    if (matrix[k, l] < matrix[i, j])
                        x += matrix[k, l];
                    else if (matrix[k, l] > matrix[i, j])
                        x = x + matrix[i, j];
                }
            }
            return x;
        }
    }
}
