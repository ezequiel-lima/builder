namespace EstudoDePadrao
{
    public class ItemDaNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota Construir()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder ComNome(string nome) 
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}
