using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Circulo
    {
        private float cRadio;
        private float pi;

        public Circulo( float cRadio, float pi) 
        {
            this.cRadio = cRadio;
            this.pi = pi;
        }

        public float AreaCirculo( ) 
        {
            return pi * ( cRadio * 2 );
        }

    }
}
