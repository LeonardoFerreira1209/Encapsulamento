

using Encapsulamento.Objetos.Mercado;

Console.WriteLine("Cria uma instância de Mercado.");

var mercado = new Mercado("GoonMarket");

Console.WriteLine($"Seta um estoque");

mercado.AdicionarEstoque("A");

Console.WriteLine($"Mercado criado {mercado.Nome}, Estoque {mercado.Estoque.QuantidadeDeProdutos()}");

Console.WriteLine($"Adicionando produtos no estoque");

mercado.Estoque.AdicionarProduto(new Produto("Macarrão", 5));

foreach (var produto in mercado.Estoque.Produtos)
{
    Console.WriteLine($"Produto adicionado {produto.Nome}, valor {produto.Valor}");
}