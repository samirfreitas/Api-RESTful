﻿namespace Api.Business.Models
{
    public class PedidoEndereco : Entity
    {
        public int PedidoId { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }

        public Pedido Pedido { get; set; }
    }
}
