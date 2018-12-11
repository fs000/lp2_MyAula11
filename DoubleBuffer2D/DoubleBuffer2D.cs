using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleBuffer2D {
    class DoubleBuffer2D<T> {

        private T[,] current;

        private T[,] next;

        private int XDim { get; }

        private int YDim { get; }

        public DoubleBuffer2D(int x, int y) {

            XDim = x;
            YDim = y;
            current = new T[XDim, YDim];
            next = new T[XDim, YDim];
            Clear();
        }

        public T this[int x, int y] {

            get {

                return current[x, y];
            }

            set {

                next[x, y] = value;
            }
        }

        public void Clear() {

            Array.Clear(next, 0, next.Length);
        }

        public void Swap() {

            T[,] aux = current;
            current = next;
            next = aux;
        }
    }
}
