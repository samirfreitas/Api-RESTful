using Api.Business.Interfaces;
using Api.Business.Models;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApiDbContext context) : base(context) { }

        public async Task<IEnumerable<Pedido>> GetAllPedidos(int pagina)
        {
            return await Db.Pedidos.AsNoTracking()
                .Include(p => p.Endereco)
                .Include(p => p.PedidoItems)
                .Include(p => p.EquipeEntrega)
                .Skip((pagina - 1) * 10)
                .Take(10)
                .OrderByDescending(p => p.DataCadastro)
                .ToListAsync();
        }

        public async Task<int> GetTotalPaginas()
        {
            var totalRegistros = await Db.Pedidos.CountAsync(); 

            if(totalRegistros == 0)
            {
                return 0;
            }

            return (totalRegistros / 10) ;
        }
    }
}
