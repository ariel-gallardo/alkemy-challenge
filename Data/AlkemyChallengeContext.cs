using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using alkemy_challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace alkemy_challenge.Data
{
    public class AlkemyChallengeContext : IdentityDbContext<ApplicationUser>
    {
        public AlkemyChallengeContext (DbContextOptions<AlkemyChallengeContext> options)
            : base(options)
        {
        }
        public DbSet<alkemy_challenge.Models.Genero> Genero { get; set; }
        public DbSet<alkemy_challenge.Models.Personaje> Personaje { get; set; }
        public DbSet<alkemy_challenge.Models.Pelicula> Pelicula { get; set; }
    }
}
