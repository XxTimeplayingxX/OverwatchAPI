using System.ComponentModel.DataAnnotations;

namespace OverwatchAPI.MODELS
{
    public class Hero
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
