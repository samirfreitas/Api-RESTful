using System;
using System.Collections.Generic;

namespace Api.Business.Models
{
    public class Pedido : Entity
    {
        public DateTime DataEntrega { get; set; }

        public PedidoEndereco Endereco { get; set; }

        public PedidoEquipeEntrega EquipeEntrega { get; set; }

        public IEnumerable<PedidoItem> PedidoItems { get; set; }
    }
}
