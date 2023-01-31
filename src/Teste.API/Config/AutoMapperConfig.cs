using AutoMapper;
using Teste.API.ViewModel;
using Teste.Domain.Models;

namespace Teste.API.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ContaViewModel, ContaModel>().ReverseMap();
        }

    }
}
