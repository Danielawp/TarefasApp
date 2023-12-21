using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;
using TarefasApp.Domain.Interfaces.Repositories;
using TarefasApp.Domain.Interfaces.Services;

namespace TarefasApp.Domain.Services
{
    /// <summary>
    /// Classe de serviços de domínio para Tarefa
    /// </summary>
    public class TarefaDomainService : ITarefaDomainService
    {

        private readonly ITarefaRepository? _tarefaRepository;
        private readonly ICategoriaRepository? _categoriaRepository;
        public TarefaDomainService(ITarefaRepository? tarefaRepository, ICategoriaRepository? categoriaRepository)
        {
            _tarefaRepository = tarefaRepository;
            _categoriaRepository = categoriaRepository;
        }

        public void Atualizar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Tarefa tarefa)
        {
            if (_categoriaRepository?.GetById(tarefa.CategoriaId.Value) == null)
                throw new ApplicationException("A categoria informada não existe. Por favor verifique.");
            _tarefaRepository?.Add(tarefa);
        }

        public List<Tarefa> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Tarefa ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
