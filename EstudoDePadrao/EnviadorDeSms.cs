namespace EstudoDePadrao
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulando envio por SMS");
        }
    }
}
