using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Eggcelent
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int eggHeight = 2 * n;
            int eggWidt = 3 * n - 1;
            int totalWidth = 3 * n + 1;
            char[,] matrix = new char[eggHeight, totalWidth];

            FillMatrix(eggHeight, totalWidth, matrix);
            
            int topRow = 0;
            int bottmRow = eggHeight - 1; //count from zeroes
            int leftPivot = (n + 1);
            for (int i = 0; i < n-1; i++, leftPivot++)
            {
                matrix[topRow, leftPivot] = '*';
                matrix[bottmRow, leftPivot] = '*';
            }
            // reseting pivot
            int rightPivot = leftPivot + 1;
            leftPivot = n-1;
            topRow++;
            bottmRow--;
            for (int i = 0; i < n/2; i++)
            {
                matrix[topRow, leftPivot] = '*';
                matrix[bottmRow, leftPivot] = '*';
                matrix[topRow, rightPivot] = '*';
                matrix[bottmRow, rightPivot] = '*';
                if (i !=n / 2-1 )
                {
                    leftPivot -= 2;
                    rightPivot += 2;
                    topRow++;
                    bottmRow--;
                }
            }
            topRow++;
            for (int i = 0; i < n-2; i++)
            {
                matrix[topRow, leftPivot] = '*';
                matrix[topRow, rightPivot] = '*';
                topRow++;
            }
            //reset
            topRow = n - 1;
            bottmRow = n;
           leftPivot++;
            for (int i = 0; i < eggWidt -2; i++)
            {
                if (i % 2 == 0)
	            {
                    matrix[topRow, leftPivot] = '@';
                    matrix[bottmRow, leftPivot] = '.';
	            }
                else
                {
                    matrix[topRow, leftPivot] = '.';
                    matrix[bottmRow, leftPivot] = '@';
                }
                leftPivot++;
            }
            PrintMatrix(eggHeight, totalWidth, matrix);
        }
        private static void FillMatrix(int eggHeight, int totalWidth, char[,] matrix)
        {
            for (int row = 0; row < eggHeight; row++)
            {
                for (int col = 0; col < totalWidth; col++)
                {
                    matrix[row, col] = '.';
                }
            }           
        }
        private static void PrintMatrix(int eggHeight, int totalWidth, char[,] matrix)
        {
            for (int row = 0; row < eggHeight; row++)
            {
                for (int col = 0; col < totalWidth; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();  
            }
            Console.ReadLine();
        }
    }
}
