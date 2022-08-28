using System;
namespace HomePetCareCats.App.Dominio
{
    public class visita
    {
        public int idVisita {get; set;}
        public float temperatura {get; set;}
        public float peso {get; set;}
        public string frecuenciaRespiratoria {get; set;}
        public string estadoAnimo {get; set;}
        public DateTime fechaVisita {get; set;}
        public string frecuenciaCardiaca {get; set;}
        public string recomendaciones {get; set;}
        public profesionalVeterinario veterinario {get; set;}
        public mascota gato {get; set;}
    
    }
}