using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleBuffer2D {
    class Program {
        static void Main(string[] args) {

            DoubleBuffer2D<char> db = new DoubleBuffer2D<char>(5, 5);

            db[0, 0] = 'a';
            db[0, 1] = 'b';
            db[0, 2] = 'c';
            db[0, 3] = 'd';
            db[0, 4] = 'e';
            db[1, 0] = 'a';
            db[1, 1] = 'b';
            db[4, 2] = 'X';

            db.Swap();

            Console.WriteLine($"{db[0, 0]}");
        }
    }
}
