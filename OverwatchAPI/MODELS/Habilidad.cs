using System.ComponentModel.DataAnnotations;

namespace OverwatchAPI.MODELS
{
    public class Habilidad
    {
        [Key]
        public int ID { get; set; }
        public int DetalleID { get; set; }
        public string Descripción { get; set; }
    }
}
