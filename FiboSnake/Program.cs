using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 13;
            var fiboSnake = new FiboSnakeImpl(n);            
            fiboSnake.ImplementFiboSnake(n);
            Console.Read();
        }
    }
}
