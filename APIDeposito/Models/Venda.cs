using Microsoft.AspNetCore.Http.Features;

namespace APIDeposito.Models;

public class Venda
{
    public int VendaId { get; set; }
    public DateTime Data { get; set; }
    public int? ClienteId { get; set; }
    //Fk para Cliente, pode ser nulo para vendas avulsas
    public Cliente? Cliente { get; set; }
    public List<ItemVenda> Itens { get; set; } =
        new(); //items vendidos
    public decimal ValorTotal => Itens.Sum(i =>
    i.Subtotal);

}
