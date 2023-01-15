using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix = new double[4, 4]
            {
                {2,6,1,8 },
                {8,2,5,2 },
                {9,3,2,5 },
                {2,3,7,2 },
            };
            Matrix x = new Matrix();
            x.SetUp();
            x.Print();
            Console.WriteLine();
            x.Print();
            Console.WriteLine(x.Square(matrix));
        }
    }
    public class Matrix
    {
        public double[,] MatrixDoubles { get; set; } // матрица
        public void SetUp()
        {
            MatrixDoubles = new double[4, 4]
            {
                {2,6,1,8 },
                {8,2,5,2 },
                {9,3,2,5 },
                {2,3,7,2 },
            };
        }
        public Matrix() {}
        public Matrix(double[,] matrixDoubles)
        {
            MatrixDoubles = matrixDoubles;
        }
        public void Print() // печать матрицы
        {
            Console.WriteLine("Исходная матрица: ");
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    Console.Write($"{MatrixDoubles[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
        public double Sum(double[,] matrixDoubles) // сумма элементов в строке 
        {
            double sum = 0; // сумма элементов в строке
            for (var i = 0; i < 4; i++)
            {
                double max = 0; // максимальное значение суммы в строке
                for (var j = 0; j < 4; j++)
                {
                    if (max < matrixDoubles[i, j])
                    {
                        max = matrixDoubles[i, j];
                    }
                    sum += matrixDoubles[i,j];
                }
            }

            return sum;
        }
        
        public double Max(double[,] matrixDoubles) // максимальное значение суммы в строке 
        {
            double max = 0; // максимальное значение суммы в строке
            for (var i = 0; i < 4; i++)
            {
                double sum = 0; // сумма элементов в строке
                for (var j = 0; j < 4; j++)
                {
                    if (max < matrixDoubles[i, j])
                    {
                        max = matrixDoubles[i, j];
                    }
                    sum += matrixDoubles[i,j];

                }
            }

            return max;
        }

        public double EvenNum(double[,] matrixDoubles) // чётные числа в строке с максимальной суммой 
        {
            double maxIndex = 0; // индекс строки с максимальной суммой
            double maxString = 0; // сумма элементов строки с максимальной суммой
            double countEven = 0; // количество чётных чисел
            for (var i = 0; i < 4; i++)
            {
                double sum = 0; // сумма элементов в строке
                for (var j = 0; j < 4; j++)
                {
                    sum += matrixDoubles[i,j];
                }

                if (maxString < sum)
                {
                    maxString = sum;
                    maxIndex = i;
                }
            }

            for (var j = 0; j < 4; j++)
            {
                if (matrixDoubles[(int)maxIndex, j] % 2 == 0)
                {
                    countEven++;
                }
            }

            return countEven;
        }
        public bool Square(double[,] matrix)
        {
            return matrix.GetLength(0) == matrix.GetLength(1);
        }
    }
}
