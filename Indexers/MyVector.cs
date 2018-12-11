using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers {
    struct MyVector {

        public float X { get; set; }

        public float Y { get; set; }

        public MyVector(int x, int y) {

            X = x;
            Y = y;
        }

        public float this[int index] {

            get {

                if (index == 0) { return X; }
                else if (index == 1) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }

            set {

                if (index == 0) { X = value; }
                else if (index == 1) { Y = value; }
            }
        }

        public float this[string s] {

            get {

                s = s.ToLower();
                if (s == "x" || s == "a" || s == "0") { return X; }
                else if (s == "y" || s == "b" || s == "1") { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }

            set {
                
                if (s == "x" || s == "a" || s == "0") { X = value; }
                else if (s == "y" || s == "b" || s == "1") { Y = value; }
            }
        }
    }
}
