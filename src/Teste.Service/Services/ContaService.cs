using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;
using Teste.Data.Repository;
using Teste.Domain.Interfaces;
using Teste.Domain.Models;

namespace Teste.Service.Services
{
    public class ContaService : IContaService
    {
        private readonly ContaRepository _itesteRepository;
        

        public ContaService(ContaRepository itesteRepository)
        {
            _itesteRepository = itesteRepository;
        }

        public async Task Adicionar(ContaModel conta)
        {
            await _itesteRepository.Adicionar(conta);
        }

        public async Task Atualizar(ContaModel conta)
        {
            await _itesteRepository.Atualizar(conta);
        }

        public async void Dispose()
        {
           _itesteRepository? .Dispose();
        }

        public async Task ObterTodos()
        {
            await _itesteRepository.ObterTodos();
        }

        public async Task Remover(Guid id)
        {
            await _itesteRepository.Remover(id);
        }
    }
}
