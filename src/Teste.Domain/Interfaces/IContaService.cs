using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Models;

namespace Teste.Domain.Interfaces
{
    public interface IContaService : IDisposable
    {
        Task Adicionar(ContaModel conta);
        Task ObterTodos();
        Task Atualizar(ContaModel conta);
        Task Remover(Guid id);

    }
}
