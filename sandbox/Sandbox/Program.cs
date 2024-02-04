// using System;

// class Program
// {
//     static void Main()
//     {
//         // Define your matrix
//         double[,] matrix = {
//             {0, 1, 3, 0, -4, 1, 0},
//             {1, 1, 1, 0, -1, 0, 0},
//             {1, 0, -2, 1, 8, -1, -1},
//             {1, -1, -5, 1, 12, 1, -1},
//             {1, 1, 1, 1, 4, 0, 1},
//             {-1, 1, 5, 1, -2, 0, 0}
//         };

//         Console.WriteLine("Original Matrix:");
//         PrintMatrix(matrix);

//         // Perform Gaussian elimination manually
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             // Make the diagonal element 1
//             double divisor = matrix[i, i];
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrix[i, j] /= divisor;
//             }

//             // Eliminate other elements in the current column
//             for (int k = 0; k < matrix.GetLength(0); k++)
//             {
//                 if (k != i)
//                 {
//                     double factor = matrix[k, i];
//                     for (int j = 0; j < matrix.GetLength(1); j++)
//                     {
//                         matrix[k, j] -= factor * matrix[i, j];
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("\nRow-Reduced Matrix:");
//         PrintMatrix(matrix);
//     }

//     static void PrintMatrix(double[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

using System;

class MatrixRowReduction
{
    static void Main()
    {
        // Define your matrix
        double[,] matrix = {
            {0, 1, 3, 0, -4, 1, 0},
            {1, 1, 1, 0, -1, 0, 0},
            {1, 0, -2, 1, 8, -1, -1},
            {1, -1, -5, 1, 12, 1, -1},
            {1, 1, 1, 1, 4, 0, 1},
            {-1, 1, 5, 1, -2, 0, 0}
        };

        // Perform Gaussian elimination
        RowReduce(matrix);

        // Display the row-reduced matrix
        PrintMatrix(matrix);
    }

    static void RowReduce(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            // Make the diagonal element 1
            double diagonalElement = matrix[i, i];
            for (int j = 0; j < colCount; j++)
            {
                matrix[i, j] /= diagonalElement;
            }

            // Eliminate other elements in the current column
            for (int k = 0; k < rowCount; k++)
            {
                if (k != i)
                {
                    double factor = matrix[k, i];
                    for (int j = 0; j < colCount; j++)
                    {
                        matrix[k, j] -= factor * matrix[i, j];
                    }
                }
            }
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
