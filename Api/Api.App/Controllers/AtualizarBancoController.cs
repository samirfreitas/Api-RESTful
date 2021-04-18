using Api.Business.Interfaces;
using Api.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtualizarBancoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;

        public AtualizarBancoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet]
        public async Task<string> Get()
        {

            var carga = new List<Pedido>();

            for (int i = 0; i < 40; i++)
            {

                if(i % 2 == 0) { 
                carga.Add(new Pedido
                {

                    DataCadastro = DateTime.Now,
                    DataEntrega = DateTime.Now.AddDays(1),
                    Endereco = new PedidoEndereco()
                    {

                        CEP = "27343-360",
                        Bairro = "Jardim America",
                        Cidade = "Barra Mansa",
                        Estado = "Rio de Janeiro",
                        Complemento = "Casa 01",
                        Logradouro = "Rua Franscisco Ribeiro",
                        Numero = "132"

                    },
                    EquipeEntrega = new PedidoEquipeEntrega()
                    {

                        Nome = "Transportadora xpto",
                        Descricao = "Transportadora  lorem ipsum",
                        PlacaVeiculo = "LKJ-2132"
                    },
                    PedidoItems = new List<PedidoItem>() {
                        new PedidoItem() {Nome="Playstation 5",Descricao="Console para jogos.", Valor = 5400},
                        new PedidoItem() {Nome="Xbox One",Descricao="Console para jogos.", Valor = 3400 }
                    },

                });

                }
                else { 

                carga.Add(new Pedido
                {

                    DataCadastro = DateTime.Now,
                    DataEntrega = DateTime.Now.AddDays(1),
                    Endereco = new PedidoEndereco()
                    {

                        CEP = "22131-360",
                        Bairro = "Voldac",
                        Cidade = "Volta Redonda",
                        Estado = "Rio de Janeiro",
                        Complemento = "Casa 01",
                        Logradouro = "Rua E",
                        Numero = "212"

                    },
                    EquipeEntrega = new PedidoEquipeEntrega()
                    {

                        Nome = "Transportadora yz",
                        Descricao = "Transportadora  lorem ipsum",
                        PlacaVeiculo = "KMK-3121"
                    },
                    PedidoItems = new List<PedidoItem>() {
                        new PedidoItem() {Nome="Piscina 2000L",Descricao="Piscina para criancas ate 6 anos.", Valor = 300},
                        new PedidoItem() {Nome="Pula pula",Descricao="Cama elastica para criancas ate 12 anos.", Valor = 4700 }
                    },

                });
                }
            }

            foreach (var item in carga)
            {
                await _pedidoRepository.Adicionar(item);
            }

            return "Carga Fake Realizada";


       
        }
    }
}
