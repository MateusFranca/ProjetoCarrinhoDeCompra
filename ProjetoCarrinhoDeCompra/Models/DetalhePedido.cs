using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCarrinhoDeCompra.Models
{
    [Table("detalhe_pedido", Schema = "public")]
    public class DetalhePedido
    {
            [Column("id")]
            public int Id { get; set; }
            [Column("descricao")]
            public int Descricao { get; set; }
            [Column("valor_unitario")]
            public string? Valor_unitario { get; set; }
            [Column("qtd")]
            public string? Qtd { get; set; }
            [Column("Subtotal")]
            public double Subtotal { get; set; }
            [ForeignKey("Pedido")]
            [Column("pedido_id")]
            public int PedidoId { get; set; }
            public virtual Pedido Pedido { get; set; }
    }
}
