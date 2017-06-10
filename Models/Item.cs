using System.Collections.Generic;

namespace Scania.PickToLight.Models
{
    public class Item
    {
        public int IdPart { get; set; }
        public string Too { get; set; }
        public string Obj { get; set; }
        public string Sname { get; set; }
        public string Text { get; set; }
        public int Pos { get; set; }
        public object Photo { get; set; }
        public int? LeftBoxes { get; set; }
        public int? RightBoxes { get; set; }
        public bool IsPicked { get; set; }
        public bool IsMissing { get; set; }
        public object TimePickingPart { get; set; }
        public int Columns { get; set; }
        public string PartName { get; set; }
        public List<Box> Boxes { get; set; }
        
    }
}