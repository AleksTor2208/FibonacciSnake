using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboSnake
{
    struct Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Value { get; set; }

        public Cell(int x, int y, string value="X")
        {
            X = x;
            Y = y;
            Value = value;
        }

    }
}
