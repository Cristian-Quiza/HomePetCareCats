namespace HomePetCareCats.App.Dominio
{
    public class ProfesionalVeterinario : Persona
    {
        public int? Id {get; set;}
        public System.Collections.Generic.List<Visita> visita { get; set; }

    }
}