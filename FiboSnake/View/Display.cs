using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboSnake.View
{
    class Display
    {
        internal static void DisplayTable(Cell[,] snakeTable, int width)
        {
            var rowCount = snakeTable.GetLength(1);
            var colCount = snakeTable.GetLength(0);
            for (int i = 0; i < snakeTable.GetLength(0); i++)
            {
                for (int j = 0; j < snakeTable.GetLength(1); j++)
                {
                    Console.Write(snakeTable[i, j].Value + "\t");
                }
                Console.WriteLine();
            }
            //int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        }
    }
}
