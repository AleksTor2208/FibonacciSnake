using FiboSnake.Factory;
using FiboSnake.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboSnake
{
    class FiboSnakeImpl
    {
        readonly int N;
        Cell[,] FiboSnakeTable;
        //Długość przed zakrętem (DPZ)
        public int DPZ = 3;

        // Wysokość przed zakrętem (WPZ)
        public int WPZ = 2;

        public FiboSnakeImpl(int n)
        {
            N = n;
        }

        // Współrzędne X, Y
        public int X = 1;
        public int Y = 1;

        public void ImplementFiboSnake(int n)
        {
            var height = CalculateTableHeight(n);
            var width = CalculateTableWidth(n, height);
            var fiboList = GetFiboList();
            var SnakeTable = SnakeTableFactory.GetEmptySnakeTable(height, width);
            //var emptyTable = InitTable(height, width);            
            AssignCells(SnakeTable, fiboList, X, Y);
            Display.DisplayTable(SnakeTable, width);
        }

        

        private void AssignCells(Cell[,] snakeTable, List<string> fiboList, int x, int y)
        {
            int index = 0;
            while (index < N)
            {
                AssignLine(new FiboSnakeData
                {
                    Length = DPZ,
                    SnakeTable = snakeTable,
                    FiboList = fiboList,
                    Coordinate = x,
                    Step = Step.Add
                });

                for (int a = 0; a < DPZ; a++)
                {                    
                    if (index >= N) break;
                    snakeTable[y, x] = new Cell(x, y, fiboList[index]);
                    if (a == DPZ - 1) break;
                    x++; index++;
                }
                DPZ++;

                for (int b = 0; b < WPZ; b++)
                {
                    if (index >= N) break;
                    snakeTable[y, x] = new Cell(x, y, fiboList[index]);
                    if (b == WPZ - 1) break;
                    y++; index++;
                }
                WPZ++;
                for (int c = 0; c < DPZ; c++)
                {
                    if (index >= N) break;
                    snakeTable[y, x] = new Cell(x, y, fiboList[index]);
                    if (c == DPZ - 1) break;
                    x--; index++;
                }
                DPZ++;
                for (int d = 0; d < WPZ; d++)
                {
                    if (index >= N) break;
                    snakeTable[y, x] = new Cell(x, y, fiboList[index]);
                    if (d == (WPZ - 1)) break;
                    y--; index++;
                }
                WPZ++;
            }
        }

        private void AssignLine(FiboSnakeData fiboSnakeData)
        {
            for (int d = 0; d < WPZ; d++)
            {
                if (index >= N) break;
                snakeTable[y, x] = new Cell(x, y, fiboList[index]);
                if (d == (WPZ - 1)) break;
                y--; index++;
            }
            WPZ++;
        }

        private List<string> GetFiboList()
        {
            return new List<string>()
            { "1", "1", "2", "3", "5", "8", "13", "21", "34", "55", "89",
                "144", "233", "377", "510", "887", "1397", "2284", "3681", "5965"};
        }

        private int CalculateTableHeight(int n)
        {
            var param = Convert.ToDouble(n);
            return (int) Math.Sqrt(param);
        }

        private int CalculateTableWidth(int n, int height)
        {
            var hasRemainder = n % height != 0;
            var result = n / height;
            if (hasRemainder) result += 1;
            return result;
        }

        private void InitTable(int heigth, int width)
        {
              
        }
    }
}
