using System.ComponentModel.DataAnnotations;

namespace OverwatchAPI.MODELS
{
    public class DetalleHabilidad
    {
        [Key]
        public int ID { get; set; }
        public int HeroID { get; set; }
        public int HabilidadesID { get; set; }
    }
}
