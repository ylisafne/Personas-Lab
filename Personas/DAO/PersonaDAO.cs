using Personas.Model;

namespace Personas.DAO
{
    public class PersonaDAO
    {
       
        public PersonaBE persona() {
            var lst = GeneraPersona();

            Random rnd = new Random();
            int num = rnd.Next(1,5);

            return lst.Where(x => x.Id == num).First();
        }
        public List<PersonaBE> PersonaXSexo(string genero) {
            var lst = GeneraPersona();
            return lst.Where(x => x.Genero == genero).ToList();

        }
        public List<PersonaBE> GeneraPersona() {
            List<PersonaBE> lst = new List<PersonaBE>();
            PersonaBE per0 = new PersonaBE{ Id= 1, Nombre = "Gabriel", Apellidos = "Silverio", Genero="M", FechaNacimiento= Convert.ToDateTime("10/10/1990")};
            PersonaBE per1 = new PersonaBE { Id = 2, Nombre = "Erickson", Apellidos = "Lyno", Genero = "M", FechaNacimiento = Convert.ToDateTime("10/10/1996") };
            PersonaBE per2 = new PersonaBE { Id = 3, Nombre = "Kelly", Apellidos = "Diaz", Genero = "F", FechaNacimiento = Convert.ToDateTime("10/10/1994") };
            PersonaBE per3 = new PersonaBE { Id = 4, Nombre = "Juan", Apellidos = "Quezada", Genero = "M", FechaNacimiento = Convert.ToDateTime("10/10/1996") };
            PersonaBE per4 = new PersonaBE { Id = 5, Nombre = "Estrella", Apellidos = "Gamarra", Genero = "F", FechaNacimiento = Convert.ToDateTime("10/10/1998") };

            lst.Add(per0);
            lst.Add(per1);
            lst.Add(per2);
            lst.Add(per3);
            lst.Add(per4);
            return lst;
        }
    }
}
