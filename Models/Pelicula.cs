using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alkemy_challenge.Models
{
    public class Pelicula
    {
        public long Id { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }
        public Genero Genero { get; set; }
        public List<Personaje> Personajes { get; set; }

    }
}
