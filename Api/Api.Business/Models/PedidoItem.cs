namespace Api.Business.Models
{
    public class PedidoItem : Entity
    {
        public int PedidoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Pedido Pedido { get; set; }
    }
}
