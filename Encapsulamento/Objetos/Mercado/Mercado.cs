namespace Encapsulamento.Objetos.Mercado;

/// <summary>
/// Objeto de Produto.
/// </summary>
public class Produto
{
    private string _nome;
    private decimal _valor;

    public string Nome => _nome;

    public decimal Valor => _valor;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="valor"></param>
    public Produto(
        string nome, 
        decimal valor
        )
    {
        _nome = nome;
        _valor = valor;
    }
}

/// <summary>
/// Objeto Estoque.
/// </summary>
public class Estoque
{
    private string _nome;
    private string _endereco;
    private List<Produto> _produtos = [];

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="nome"></param>
    public Estoque(
           string nome
       )
    {
        _nome = nome;
    }

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="produtos"></param>
    public Estoque(
            string nome,
            List<Produto> produtos
        )
    {
        _nome = nome;
        _produtos = produtos;
    }

    /// <summary>
    /// Atributo de acesso a produtos.
    /// </summary>
    public List<Produto> Produtos => _produtos;

    /// <summary>
    /// Adiciona um produto ao estoque.
    /// </summary>
    /// <param name="produto"></param>
    public void AdicionarProduto(Produto produto) =>
        _produtos.Add(produto);

    /// <summary>
    /// Remove um produto do estoque.
    /// </summary>
    /// <param name="produto"></param>
    public void RemoverProduto(Produto produto) =>
     _produtos.Remove(produto);

    /// <summary>
    /// Valor total dos produtos no estoque.
    /// </summary>
    /// <returns></returns>
    public decimal ValorTotalDosProdutos() =>
        _produtos.Sum(x => x.Valor);

    /// <summary>
    /// Quantidade de produtos no estoque.
    /// </summary>
    /// <returns></returns>
    public int QuantidadeDeProdutos() => 
        _produtos?.Count ?? 0;
}

/// <summary>
/// Objeto mercado.
/// </summary>
public class Mercado
{
    private string _nome;
    private Estoque _estoque;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="nome"></param>
    public Mercado(
        string nome
        )
    {
        _nome = nome;
    }

    /// <summary>
    /// Atributo de acesso a estoque.
    /// </summary>
    public Estoque Estoque => _estoque;

    /// <summary>
    /// 
    /// </summary>
    public string Nome => _nome;

    /// <summary>
    /// Adiciona um novo estoque.
    /// </summary>
    /// <param name="nome"></param>
    public void AdicionarEstoque(string nome) 
        => _estoque = new Estoque(nome);  
}
