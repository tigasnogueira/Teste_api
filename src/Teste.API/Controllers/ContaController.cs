using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Teste.API.ViewModel;
using Teste.Data.Repository;
using Teste.Domain.Interfaces;
using Teste.Domain.Models;

namespace Teste.API.Controllers
{
    public class ContaController : HomeController
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICepService _cepService;
        private readonly IContaRepository _contaRepository;
        private readonly IContaService _contaService;
        private readonly IMapper _mapper;

        public ContaController(IHttpContextAccessor contextAccessor,
            ICepService cepService,
            IContaService contaService,
            IMapper mapper,
            IContaRepository contaRepository,
            INotificador notificador) : base(notificador)
        {
            _contextAccessor = contextAccessor;
            _contaService = contaService;
            _contaRepository = contaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ContaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ContaViewModel>>(await _contaRepository.ObterTodos());
        }



        [HttpGet("{id:guid}")]
        public async Task <ContaViewModel> ObterpId( Guid id)
        {
            return _mapper.Map<ContaViewModel>(await _contaRepository.ObterPorId(id));
        }



        [HttpPost]

        public async Task<ActionResult<ContaViewModel>> Adicionar (ContaViewModel contaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            await _contaService.Adicionar(_mapper.Map<ContaModel>(contaViewModel));

            return CustomResponse(contaViewModel);
        }

        [HttpPut("{id:guid}")]

        public async Task<ActionResult<ContaViewModel>> Atualizar (Guid id, ContaViewModel conta)
        {
            if (id != conta.Id)
            {
                NotificarErro("ID incorreto");
                return CustomResponse(conta);
            }
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _contaService.Atualizar(_mapper.Map<ContaModel>(conta));

            return CustomResponse(conta);
        }


        [HttpDelete]
        public async Task<ActionResult<ContaViewModel>> Excluir(Guid id)
        {
            var conta = await ObterpId(id);
            if (conta == null) return NotFound();

            await _contaService.Remover(id);

            return CustomResponse(conta);

        }


        //[HttpGet]

        //public Task







    }
}
