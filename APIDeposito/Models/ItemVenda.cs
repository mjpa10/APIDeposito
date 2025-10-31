namespace APIDeposito.Models;

public class ItemVenda
{
    public int ItemVendaId { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Subtotal => Quantidade * PrecoUnitario;

    public int VendaId { get; set; }
    public Venda? Venda { get; set; }

    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }
}
