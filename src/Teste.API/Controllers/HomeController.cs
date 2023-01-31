using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Teste.Domain.Interfaces;
using Teste.Domain.Notificacoes;

namespace Teste.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected HomeController(INotificador notificador)
        {
            _notificador = notificador;
        }


        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    succes = true,
                    data = result

                });
            }
            return BadRequest(new
            {
                succes = false,
                errors = _notificador.ObterNotificacao().Select(n => n.Mensagem)
            });
        }


        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if(!modelState.IsValid) NotificadorErroModelInvalida(modelState);
            return CustomResponse();
        }



        protected void NotificadorErroModelInvalida(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(e => e.Errors);
            foreach (var error in errors)
            {
                var errorMsg = error.Exception == null? error.ErrorMessage: error.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }


    }
}