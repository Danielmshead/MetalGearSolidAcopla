using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAcopla
{
    class GeraNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;
        public GeraNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobre0(valor));

            foreach (var acao in acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobre0(double valor)
        {
            return valor  * 0.06;
        }
    }
}
