namespace Api.Business.Models
{
    public class PedidoEquipeEntrega : Entity
    {
        public int PedidoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string PlacaVeiculo { get; set; }
        public Pedido Pedido { get; set; }
    }

}
