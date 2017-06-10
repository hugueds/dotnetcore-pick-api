using System.Collections.Generic;

namespace Scania.PickToLight.Models
{
    public class GroupStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QtdWagon { get; set; }
        public List<PickStation> Stations { get; set; }
        
    }
}