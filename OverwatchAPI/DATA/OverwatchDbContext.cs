using Microsoft.EntityFrameworkCore;
using OverwatchAPI.MODELS;

namespace OverwatchAPI.DATA
{
    public class OverwatchDbContext : DbContext 
    {
        public OverwatchDbContext(DbContextOptions<OverwatchDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Habilidad> Habilidades { get; set; }
        public DbSet<DetalleHabilidad> DetalleHabilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var hero1 = new Hero() {ID=1, Name = "Tracer", Description = "Tracer es un ágil y valiente piloto de " +
                "pruebas que se convirtió en una heroína del tiempo. Su habilidad para manipular el tiempo la " +
                "convierte en una fuerza formidable en el campo de batalla, permitiéndole teletransportarse rápidamente " +
                "y deshacer los daños recibidos." };
            var hero2 = new Hero() {ID=2, Name = "Reaper", Description = "Reaper es un misterioso mercenario que esconde " +
                "su rostro bajo una máscara de calavera. Utiliza una combinación de habilidades oscuras y tácticas " +
                "sigilosas para acechar a sus enemigos y eliminarlos con su par de escopetas infernales." };

            var detallesHabilidades1 = new DetalleHabilidad {ID=1, HeroID = 1, HabilidadesID = 1 };
            var detallesHabilidades2 = new DetalleHabilidad {ID=2, HeroID = 1, HabilidadesID = 2 };

            var habilidad1 = new Habilidad {ID=1, Descripción = "Blink", DetalleID = 1 };
            var habilidad2 = new Habilidad {ID=2, Descripción = "Recall", DetalleID = 1 };

            modelBuilder.Entity<Hero>().HasData(new Hero[] { hero1, hero2 });
            modelBuilder.Entity<DetalleHabilidad>().HasData(new DetalleHabilidad[] { detallesHabilidades1, detallesHabilidades2 });
            modelBuilder.Entity<Habilidad>().HasData(new Habilidad[] { habilidad1, habilidad2 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
