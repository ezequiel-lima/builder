using EstudoDePadrao;

/* Utilizando Padrão Builder */
NotaFiscalBuilder criador = new NotaFiscalBuilder();

criador
    .ParaEmpresa("Empresa teste")
    .ComCnpj("23.456.789/0001-12")
    .ComItem(new ItemDaNota("Item de teste", 100))
    .ComItem(new ItemDaNota("Segundo item de teste", 200))
    .ComObservacoes("qualquer obs")
    .AdicionaAcao(new EnviadorDeEmail())
    .AdicionaAcao(new EnviadorDeSms())
    .AdicionaAcao(new NotaFiscalDao());

NotaFiscal notaFiscal = criador.Constroi();

Console.WriteLine(notaFiscal.ValorBruto);
Console.WriteLine(notaFiscal.Impostos);
Console.WriteLine(notaFiscal.DataDeEmissao);


/* FORMA NORMAL DE CRIAR NOTA FISCAL */
IList<ItemDaNota> itens = new List<ItemDaNota>();

double valorTotal = 0;
foreach (var item in itens)
{
    valorTotal += item.Valor;
}

double impostos = valorTotal * 0.05;

NotaFiscal nf = new NotaFiscal("razao", "cnpj", DateTime.Now, 250, impostos, itens, "observaçoes");

/* Exercico */

ItemDaNotaBuilder itemDaNotaBuilder = new ItemDaNotaBuilder();

itemDaNotaBuilder
    .ComNome("Nome item teste")
    .ComValor(250);

ItemDaNota itemDaNota = itemDaNotaBuilder.Construir();

Console.WriteLine(itemDaNota.Nome + " " + itemDaNota.Valor);