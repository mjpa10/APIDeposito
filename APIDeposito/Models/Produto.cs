using System.Collections.ObjectModel;

namespace APIDeposito.Models;

public class Produto
{
    public Produto()
    {
        ItemVendas = new Collection<ItemVenda>();
    }
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    // (ex: cerveja Skol 350ml,cerveja heineken 350ml, Coca-Cola 2L, sprite 2l)
    public string? Categoria { get; set; }
    //(ex: "Cerveja", "Refrigerante", "Carvão")
    public decimal Preco { get; set; }
    public int QuantidadeEstoque { get; set; }

    public ICollection<ItemVenda>? ItemVendas { get; set;}

}
