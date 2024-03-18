using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Triangulo
    {
        private float tBase;
        private float tAltura;

        public Triangulo( float tBase, float tAltura)
        {
            this.tBase = tBase;
            this.tAltura = tAltura;
        }

        public float AreaTriangulo()
        { return tBase * tAltura / 2 ; }
    }
}
