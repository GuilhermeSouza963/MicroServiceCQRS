using AutoMapper;
using MicroServiceCQRS.Application.ViewModels;
using MicroServiceCQRS.Domain.Entities;

namespace MicroServiceCQRS.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
           CreateMap<Objeto, ObjetoViewModel>();
            CreateMap<DisciplinaObjeto, DisciplinaObjetoViewModel>();
        }
    }
}
