using AutoMapper;
using MicroServiceCQRS.Application.ViewModels;
using MicroServiceCQRS.Domain.Commands.DisciplinaObjetoCommands;
using MicroServiceCQRS.Domain.Commands.ObjetoCommands;

namespace MicroServiceCQRS.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ObjetoViewModel, RegisterNewObjetoCommand>()
                .ConstructUsing(c => new RegisterNewObjetoCommand(
                    c.ObjetoIdPai,
                    c.ObjetoIdPaiPrincipal,
                    c.ObjetoTipoId,
                    c.ModeloId,
                    c.Titulo,
                    c.Descricao,
                    c.Conteudo,
                    c.DataExibirInicio,
                    c.DataExibirFim,
                    c.Ordem,
                    c.SituacaoId,
                    c.PessoaId,
                    c.Urgente,
                    c.DataAula,
                    c.StatusId,
                    c.Usuario,
                    c.CriadoEm,
                    c.AtualizadoEm));

            CreateMap<DisciplinaObjetoViewModel, RegisterNewDisciplinaObjetoCommand>()
                .ConstructUsing(c => new RegisterNewDisciplinaObjetoCommand(
                    c.DisciplinaId,
                    c.ObjetoId,
                    c.Ordem,
                    c.PesquisaId,
                    c.StatusId,
                    c.Usuario,
                    c.CriadoEm,
                    c.AtualizadoEm));
        }
    }
}
