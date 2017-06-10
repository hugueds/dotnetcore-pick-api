using Newtonsoft.Json;

namespace Scania.PickToLight.Models
{
    public class Log
    {
        [JsonProperty("idWagon")]
        public int IdWagon { get; set; }
        [JsonProperty("user")]
        public string User { get; set; }
        [JsonProperty("justification")]
        public string Justification { get; set; }
        [JsonProperty("connection")]
        public string Connection { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",IdWagon,User,Justification,Connection);
        }

    }
}