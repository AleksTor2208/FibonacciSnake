using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboSnake
{
    class SnakeTableFactory
    {
        public static Cell[,] GetEmptySnakeTable(int height, int width) // 3, 5
        {
            var FiboSnakeTable = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {                    
                    FiboSnakeTable[i, j] = new Cell(i, j);
                }
            }
            return FiboSnakeTable;
        }
    }
}
