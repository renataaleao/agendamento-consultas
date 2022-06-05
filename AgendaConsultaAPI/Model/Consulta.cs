using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaConsultaAPI.Model
{
    [Table(name:"consultas")]
    public class Consulta
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(120)]
        public string NomePaciente { get; set; }
        public double Cpf { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }

    }
}
