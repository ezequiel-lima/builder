namespace EstudoDePadrao
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulando salvar no banco");
        }
    }
}
