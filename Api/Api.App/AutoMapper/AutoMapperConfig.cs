using Api.App.ViewModels;
using Api.Business.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
      public AutoMapperConfig()
        {
            CreateMap<Pedido, PedidoViewModel>().ReverseMap();
            CreateMap<PedidoEndereco, PedidoEnderecoViewModel>().ReverseMap();
            CreateMap<PedidoEquipeEntrega, PedidoEquipeEntregaViewModel>().ReverseMap();
            CreateMap<PedidoItem, PedidoItemViewModel>().ReverseMap();
        }
    }
}
