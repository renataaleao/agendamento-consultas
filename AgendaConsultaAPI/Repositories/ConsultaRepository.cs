using AgendaConsultaAPI.DTO;
using AgendaConsultaAPI.Model;
using AgendaConsultaAPI.Model.Entities.Consultas;

namespace AgendaConsultaAPI.Repositories
{

    public interface IConsultaRepository
    {
        public bool Create(PostConsultas consulta);
        public List<ConsultaDTO> getAll();
        public Consulta Read(int id);
        public bool Update(PutConsultas consulta);
        public bool Delete(int id);
    }
    public class ConsultaRepository : IConsultaRepository
    {
        
        private readonly _DbContext db;
        

        public ConsultaRepository(_DbContext _db)
        {
            db = _db;
        }

        public bool Create(PostConsultas consulta)
        {
            try
            {
                
                var consulta_db = new Consulta()
                {
                    NomePaciente = consulta.NomePaciente,
                    Cpf = consulta.Cpf,
                    Dia = consulta.Dia,
                    Hora = consulta.hora,
                };
                db.Consultas.Add(consulta_db);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ConsultaDTO> getAll()
        {
            List<ConsultaDTO> consultasDTO = new List<ConsultaDTO>();
            foreach (var item in db.Consultas.ToList())
            {
                consultasDTO.Add(ModelToDto(item));
            }
            return consultasDTO;
        }

        public Consulta Read(int id)
        {
            try
            {
                var consultas_db = db.Consultas.Find(id);

                return consultas_db;
            }
            catch
            {
                return new Consulta();
            }
        }

        public bool Update(PutConsultas consulta)
        {
            try
            {

                var consultas_db = db.Consultas.Find(consulta.Id);
                consultas_db.NomePaciente = consulta.NomePaciente;
                consultas_db.Cpf = consulta.Cpf;
                consultas_db.Dia = consulta.Dia;
                consultas_db.Hora = consulta.hora;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var consultas_db = db.Consultas.Find(id);
                db.Consultas.Remove(consultas_db);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ConsultaDTO ModelToDto(Consulta consulta)
        {
            ConsultaDTO consultaDTO = new ConsultaDTO();
            consultaDTO.Id = consulta.Id;
            consultaDTO.NomePaciente = consulta.NomePaciente;
            consultaDTO.Cpf = consulta.Cpf;
            consultaDTO.Dia = consulta.Dia;
            consultaDTO.Hora = consulta.Hora;

            return consultaDTO;
        }
    }
}
