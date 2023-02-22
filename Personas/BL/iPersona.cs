using Personas.Model;

namespace Personas.BL
{
    
    public interface iPersona
    {
        public PersonaBE GetPersona();
        public List<PersonaBE> PersonasPorSexo(string genero);


    }
}
