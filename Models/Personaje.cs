using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alkemy_challenge.Models
{
    public class Personaje
    {
        public long Id { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public double Peso { get; set; }
        public string Historia { get; set; }
        public List<Pelicula> Peliculas { get; set; }
    }
}
