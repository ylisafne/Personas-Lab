using System.ComponentModel.DataAnnotations.Schema;

namespace Personas.Model
{
    public class PersonaBE
    {

        public int Id { get; set; }
        public string Nombre { get; set; }  
        public string Apellidos { get; set; }   
        public string Genero { get; set; } 
        
        public DateTime FechaNacimiento { get; set; }

        [NotMapped]
        public int Edad { get { return DateTime.Now.Year - FechaNacimiento.Year; }}

    }
}
