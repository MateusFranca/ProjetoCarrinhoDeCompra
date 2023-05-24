using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCarrinhoDeCompra.Models
{
    [Table("pedido", Schema = "public")]

    public class Pedido
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("cpf")]
        public string? Cpf { get; set; }
        [Column("nome")]
        public string? Nome { get; set; }
        [Column("total")]
        public double Total { get; set; }
        [Column("datas")]
        public string? Data { get; set; }
    }
}
