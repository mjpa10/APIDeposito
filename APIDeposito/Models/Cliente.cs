using System.Collections.ObjectModel;

namespace APIDeposito.Models;

public class Cliente
{
    public Cliente()
    {
        Vendas = new Collection<Venda>();

    }
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }

    public ICollection<Venda> Vendas { get; set; }
}
