using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface de repositotio especifica oara tarefa 
    /// </summary>
    public interface ITarefaRepository : IBaseRepository<Tarefa>
    {

    }
}
