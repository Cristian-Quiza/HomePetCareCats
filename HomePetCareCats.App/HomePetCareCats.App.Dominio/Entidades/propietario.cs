using System;
namespace HomePetCareCats.App.Dominio
{
    public class Propietario : Persona
    {       
        public int? Id {get; set;}
        public Mascota? Gato {get; set;}
        public DateTime? Direccion {get; set;}

    }
}