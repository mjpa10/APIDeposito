namespace APIDeposito.Models;

public class ItemVenda
{
    public int ItemVendaId { get; set; }
    public int VendaId { get; set; }
    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }
    public int? Quantidade { get; set; }

    private decimal? _PrecoUnitario;

    public decimal PrecoUnitario
    {
        get => _PrecoUnitario ?? Produto?.Preco ?? 0;
        set => _PrecoUnitario = value;
    }
    public decimal Subtotal => (Quantidade ?? 0) * PrecoUnitario;

}
