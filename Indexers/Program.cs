using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers {
    class Program {
        static void Main(string[] args) {

            int x = 800;
            int y = 600;

            MyVector mv = new MyVector(x, y);

            Console.WriteLine(mv[0]);
            Console.WriteLine(mv[1]);
            Console.WriteLine(mv["y"]);
            Console.WriteLine(mv["a"]);
            Console.WriteLine(mv["B"]);
        }
    }
}
