using Personas.DAO;
using Personas.Model;

namespace Personas.BL
{
    
    public class PersonaBL : iPersona
    {
        PersonaDAO dao = new PersonaDAO();
        public PersonaBE GetPersona() { 
        return dao.persona(); 
        }
        public List<PersonaBE> PersonasPorSexo(string genero)
        {
            return dao.PersonaXSexo(genero);
        }
    }
}
