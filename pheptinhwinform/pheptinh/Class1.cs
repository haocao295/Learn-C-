using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pheptinh
{
    class pheptinh
    {
        private float sothunhat;
        private float sothuhai;

        public pheptinh()
        {
            this.sothunhat = 0;
            this.sothuhai = 0;

        }
        public pheptinh(float sothunhat, float sothuhai)
        {
            this.sothunhat = sothunhat;
            this.sothuhai = sothuhai;
        }
        public float tinhtong()
        {
            return (this.sothunhat + this.sothuhai);
        }
        public float tinhhieu()
        {
            return (this.sothunhat - this.sothuhai);
        }
        public float tinhtich()
        {
            return (this.sothunhat * this.sothuhai);
        }
        public float tinhthuong()
        {
            return (this.sothunhat / this.sothuhai);
        }

    }
}
