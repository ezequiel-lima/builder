namespace EstudoDePadrao
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public Multiplicador(double fator)
        {
            Fator = fator;
        }

        public double Fator { get; set; }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}
