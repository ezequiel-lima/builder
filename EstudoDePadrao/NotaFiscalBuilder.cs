namespace EstudoDePadrao
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; set; }

        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            // Caso não seja informado a data ela coloca como padrão a Data Atual
            DataDeEmissao = DateTime.Now;
        }

        public NotaFiscal Constroi()
        {
            
            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacao)
        {
            Observacoes = observacao;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            DataDeEmissao = data;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }
}
