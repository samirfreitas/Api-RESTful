using System;
using System.Collections.Generic;

namespace Api.App.ViewModels
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public DateTime DataEntrega { get; set; }
        public PedidoEnderecoViewModel Endereco { get; set; }
        public PedidoEquipeEntregaViewModel EquipeEntrega { get; set; }
        public IEnumerable<PedidoItemViewModel> PedidoItems { get; set; }
    }

}
