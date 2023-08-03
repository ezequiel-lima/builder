namespace EstudoDePadrao
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    { 
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulando envio do email");
        }
    }
}
