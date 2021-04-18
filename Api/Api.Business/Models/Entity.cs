using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Business.Models
{
    public class Entity
    {
        public Entity()
        {
            DataCadastro = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
