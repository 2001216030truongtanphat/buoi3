using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class ToaDo
    {
        private int toadoX;
        private int toadoY;
        private string tentoaDo;

        public int ToaDoX { get{return toadoX;} set{toadoX = value;} }
        public int ToaDoY { get{return toadoY;} set{toadoY = value;} }
        public string TenToaDo { get { return tentoaDo; } set { tentoaDo = value; } }
        public ToaDo()
        {
            toadoX = 0;
            toadoY = 0;
            tentoaDo = "O";
        }
        public ToaDo(int tx, int ty, string tentd)
        {
            this.toadoX = tx;
            this.toadoY = ty;
            this.tentoaDo = tentd;
        }
        public override string ToString()
        {
            return "ToaDo: " + tentoaDo + "(" + toadoX + " ," + toadoY + ")";
        }
    }
}
