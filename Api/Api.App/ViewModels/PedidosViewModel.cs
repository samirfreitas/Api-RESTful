using System.Collections.Generic;

namespace Api.App.ViewModels
{
    public class PedidosViewModel
    {
        public List<PedidoViewModel> Pedidos { get; set; } = new List<PedidoViewModel>();

        public int QtdPaginas { get; set; }        
        public int PaginaAtual { get; set; }
    }

}
