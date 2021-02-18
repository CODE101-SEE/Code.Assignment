using Newtonsoft.Json;

namespace Code.Assignment.Models.StarWars
{
    public class LightSaber
    {
        public string Id { get; set; }
        public string Color { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Attack { get; set; }
        public double Defense { get; set; }

        public LightSaberType Type { get; set; }

        public string JediId { get; set; }
        [JsonIgnore]
        public virtual Jedi Jedi { get; set; }
    }
}