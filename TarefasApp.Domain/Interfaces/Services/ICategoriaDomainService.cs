using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Interface para os métodos de serviço de domínio de 
    /// </summary>
    public interface ICategoriaDomainService
    {
        List<Categoria> Consultar();
    }
}
