using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alkemy_challenge.Models
{
    public class Genero
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public List<Pelicula> Peliculas { get; set; }
    }
}
