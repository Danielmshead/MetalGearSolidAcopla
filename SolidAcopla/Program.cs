namespace SolidAcopla
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender();
            NfDao nfDao = new NfDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EmailSender());
            acoes.Add(new NfDao());
            acoes.Add(new Sap());
            GeraNotaFiscal gNf = new GeraNotaFiscal(acoes);

            Fatura fatura= new Fatura(200, "Daniel MS ");

            gNf.Gera(fatura);

            Console.ReadKey();  
        }
    }
}
