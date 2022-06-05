using System.ComponentModel.DataAnnotations;

namespace AgendaConsultaAPI.Model.Entities.Consultas
{
    public class PostConsultas
    {
        [Required, MaxLength(120)]
        public string NomePaciente { get; set; }
        public double Cpf { get; set; }
        public string Dia { get; set; }
        public string hora { get; set; }

    }
}
