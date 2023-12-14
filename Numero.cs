using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7WF
{
    internal class Numero
    {
        private int n1;
        private int n2;

        public Numero(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public Numero()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

        public void SetN1(int N1)
        {
            this.n1 = N1;
        }

        public void SetN2(int N2)
        {
            this.n2 = N2;
        }

        public int GetN1()
        { 
            return this.n1; 
        }

        public int GetN2()
        {
            return this.n2;
        }

        public int ObterMaiorValor()
        {
            return Math.Max(n1, n2);
        }
    }
}
