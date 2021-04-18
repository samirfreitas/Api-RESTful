using Api.App.ViewModels;
using Api.Business.Interfaces;
using Api.Business.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.App.Controllers
{
    [Authorize]
    [ApiController]    
    [Route("[controller]")]
    public class PedidosController : Controller
    {
        private readonly  IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidosController(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }
      

        [HttpGet]
        public async Task<PedidosViewModel> Get(int pagina)
        {           

            var retorno = new PedidosViewModel();                      
            var pedidos = await _pedidoRepository.GetAllPedidos(pagina);

            retorno.PaginaAtual = pagina;
            retorno.QtdPaginas = await _pedidoRepository.GetTotalPaginas();

            retorno.Pedidos = _mapper.Map<List<PedidoViewModel>>(pedidos);
       
            return retorno;
          
        }
    }
}
