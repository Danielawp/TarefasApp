using AutoMapper;
using TarefasApp.Domain.Entities;
using TarefasApp.Services.Models;

namespace TarefasApp.Services.Mappings
{
    /// <summary>
    /// Classe para mapeamento das cópias de dados feitas pelo AutoMapper
    /// </summary>
    public class AutoMapperConfig : Profile
    {
        //método construtor -> [ctor] + 2x[tab]
        public AutoMapperConfig()
        {
            //Copiar os dados de TarefasPostModel para > Tarefa
            CreateMap<TarefasPostModel, Tarefa>()
                .AfterMap((model, entity) =>
                {
                    entity.Id = Guid.NewGuid();
                });

            //Copiar os dados de Categoria para > CategoriasGetModel
            CreateMap<Categoria, CategoriasGetModel>();

            //Copiar os dados de TarefasPutModel para > Tarefa
            CreateMap<TarefasPutModel, Tarefa>();

            //Copiar os dados de Tarefa para > TarefasGetModel
            CreateMap<Tarefa, TarefasGetModel>();
        }
    }
}



