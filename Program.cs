using System;

namespace gbhw8
{
    class Program
    {
        // // 1, 2, 3, 4, 5...
        // static int ReadInt(string prompt){
        //     System.Console.Write(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }
        
        // // 1, 2, 3, 5...
        // static int[,] GenerateArray(int rows, int cols){
        //     int[,] array = new int[rows, cols];
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             array[i, j] = new Random().Next(0, 10);
        //         }
        //     }
        //     return array;
        // }

        // static void WriteArray(int[,] array){
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             System.Console.Write(array[i, j] + "\t");
        //         }
        //         System.Console.WriteLine();
        //     }
        //     System.Console.WriteLine();
        // }

        // // 1...
        // static void BubbleSort2d(int[,] array){
        //     int temp = 0;
        //     for (int a = 0; a < array.GetLength(0); a++)
        //     {
        //         for (int j = 0; j < array.GetLength(1) - 1; j++)
        //         {
        //             for (int k = 0; k < array.GetLength(1) - 1; k++)
        //             {
        //                 if (array[a, k] < array[a, k + 1]) {
        //                     temp = array[a, k + 1];
        //                     array[a, k + 1] = array[a, k];
        //                     array[a, k] = temp;
        //                 }
        //             }
        //         }
        //     }
        // }

        // // 2...
        // static int[] SumRows(int[,] array){
        //     int[] sumsOfRows = new int[array.GetLength(0)];
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             sumsOfRows[i] += array[i, j];
        //         }
        //     }
        //     return sumsOfRows;
        // }

        // static int FindMinIdx(int[] array){
        //     int minIdx = 0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[minIdx] > array[i]){
        //             minIdx = i;
        //         }
        //     }
        //     return minIdx;
        // }

        // // 3...
        // static int[] GetRowOfArray(int[,] array, int row){
        //     int[] result = new int[array.GetLength(1)];
        //     for (int i = 0; i < array.GetLength(1); i++)
        //     {
        //         result[i] = array[row, i];
        //     }
        //     return result;
        // }

        // static int[] GetColOfArray(int[,] array, int col){
        //     int[] result = new int[array.GetLength(0)];
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         result[i] = array[i, col];
        //     }
        //     return result;
        // }

        // static int DotProduct(int[] row, int[] col){
        //     int result = 0;
        //     for (int i = 0; i < row.Length; i++)
        //     {
        //         result += row[i]*col[i];
        //     }
        //     return result;
        // }

        // static int[,] MatrixMultiply(int[,] first, int[,] second){
        //     int[,] product = new int[first.GetLength(0), second.GetLength(1)];
        //     for (int i = 0; i < first.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < second.GetLength(1); j++)
        //         {
        //             product[i, j] = DotProduct(GetRowOfArray(first, i), GetColOfArray(second, j));
        //         }
        //     }
        //     return product;
        // }

        // // 4...
        // static int[,,] Generate3dArray(int x, int y, int z){
        //     int[,,] array = new int[x, y, z];
        //     for (int i = 0; i < x; i++)
        //     {
        //         for (int j = 0; j < y; j++)
        //         {
        //             for (int k = 0; k < z; k++)
        //             {
        //                 array[i, j, k] = new Random().Next(0, 10);
        //             }
        //         }
        //     }
        //     return array;
        // }

        // static void Write3dArrayWithIndices(int[,,] array){
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             for (int k = 0; k < array.GetLength(2); k++)
        //             {
        //                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
        //             }
        //             Console.WriteLine();
        //         }
        //     }
        // }

        // // 5...
        // static int[,] FillArrayAsSpiral(int rows, int cols)
        // {
        //     int[,] array = new int[rows, cols];
        //     int top = 0;
        //     int bottom = rows-1;
        //     int left = 0;
        //     int right = cols-1;
        //     int number = 1;
        
        //     while (left <= right && top <= bottom)
        //     {
        //         for (int i = left; i <= right; i++)
        //         {
        //             array[top, i] = number;
        //             number++;
        //         }
        //         top++;

        //         for (int i = top; i <= bottom; i++)
        //         {
        //             array[i, right] = number;
        //             number++;
        //         }
        //         right--;

        //         for (int i = right; i >= left; i--){
        //             array[bottom, i] = number;
        //             number++;
        //         }
        //         bottom--;

        //         for (int i = bottom; i >= top; i--){
        //             array[i, left] = number;
        //             number++;
        //         }
        //         left++;
        //     }
        //     return array;
        // }

        static void Main(string[] args)
        {
            // // 1...
            // int[,] array1 = GenerateArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: "));
            // WriteArray(array1);
            // BubbleSort2d(array1);
            // WriteArray(array1);

            // // 2...
            // int[,] array2 = GenerateArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: "));
            // WriteArray(array2);
            // Console.WriteLine(FindMinIdx(SumRows(array2))+1);

            // // 3...
            // int[,] array3 = GenerateArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: "));
            // int[,] array4 = GenerateArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: "));
            // WriteArray(array3);
            // WriteArray(array4);
            // WriteArray(MatrixMultiply(array3, array4));

            // 4...
            // Write3dArrayWithIndices(Generate3dArray(ReadInt("Enter number of layers: "), ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: ")));

            // 5...
            // int dimension = ReadInt("Enter square dimension: ");
            // WriteArray(FillArrayAsSpiral(dimension, dimension));
        }
    }
}
