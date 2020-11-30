using FluentValidation.Results;
using MicroServiceCQRS.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Application.Interfaces
{
    public interface IObjetoAppService : IDisposable
    {
        Task<ObjetoViewModel> GetById(int objetoId);
        Task<IEnumerable<ObjetoViewModel>> GetAll();
        Task<ValidationResult> Add(ObjetoViewModel entidade);        
    }
}
