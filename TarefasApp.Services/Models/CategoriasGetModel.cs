namespace TarefasApp.Services.Models
{
    /// <summary>
    /// Modelo de dados para a resposta de consulta de categorias
    /// GET/api/categoria
    /// </summary>
    public class CategoriasGetModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
    }
}
