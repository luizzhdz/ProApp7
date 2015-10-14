using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AplicacionTorres
{
    class Hanoi
    {
        public Stack torre1 { set; get; }
        public Stack torre2 { set; get; }
        public Stack torre3 { set; get; }

        public Hanoi()
        {
            torre1 = new Stack(); 
            torre2 = new Stack();
            torre3 = new Stack();
        }

        public void clear()
        {
            torre1.Clear();
            torre2.Clear();
            torre3.Clear();
        }
    }
}
