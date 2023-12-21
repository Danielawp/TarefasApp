using System.ComponentModel.DataAnnotations;

namespace TarefasApp.Services.Models
{
    /// <summary>
    /// Modelo dedados para a requisição de cadastro de tarefas 
    /// POST/api/tarefas
    /// </summary>
    public class TarefasPostModel
    {
        [MaxLength(100, ErrorMessage = "Por favor, infome no maximo{1} caracter.")]
        [MinLength(8, ErrorMessage = "Por favor, infome no minimo{1} caracter.")]
        [Required(ErrorMessage = "Por favor, Informe o nome da tarefa.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, Informe a data e a hora da tarefa.")]
        public DateTime? DataHora { get; set; }

        [MaxLength(250, ErrorMessage = "Por favor, infome no minimo{1} caracter.")]
        [MinLength(8, ErrorMessage = "Por favor, infome no minimo{1} caracter.")]
        [Required(ErrorMessage = "Por favor, Informe o decreção da tarefa.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, Informe o prioridade da tarefa.")]
        [Range(1,3, ErrorMessage =("Por favor, informe qual nivel da prioridade."))]
        public int? Prioridade { get; set; }

        [Required(ErrorMessage = "Por favor, Informe o id da categoria.")]
        public Guid? CategoriaId { get; set; }

    }
}
