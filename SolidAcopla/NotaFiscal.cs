using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAcopla
{
    public class NotaFiscal
    {
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public double ValorLiquido
        {
            get
            {
                return this.ValorBruto - this.Impostos;
            }

        }

        public NotaFiscal(double valorBruto, double impostos)
        {
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
        }
    }
}
