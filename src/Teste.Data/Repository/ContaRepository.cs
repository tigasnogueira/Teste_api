using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Data.Context;
using Teste.Domain.Interfaces;
using Teste.Domain.Models;

namespace Teste.Data.Repository
{
    public class ContaRepository : Repository<ContaModel>, IContaRepository
    {
        public ContaRepository(MeuDbContext context) : base(context) { }

    }
}
