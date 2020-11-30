using FluentValidation.Results;
using MicroServiceCQRS.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Application.Interfaces
{
    public interface IDisciplinaObjetoAppService : IDisposable
    {
        Task<DisciplinaObjetoViewModel> GetById(int disciplinaId, int objetoId);
        Task<ValidationResult> Add(DisciplinaObjetoViewModel disciplinaObjeto);
    }
}
