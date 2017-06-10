using System;
using System.Collections.Generic;

namespace Scania.PickToLight.Models
{
    public class Wagon
    {
        public int WagonId { get; set; }
        public int WagonSeq { get; set; }
        public List<Item> Items { get; set; }
        public DateTime WagonDate { get; set; }
        public bool Marked { get; set; }
        public int StationId { get; set; }
        public string StationName { get; set; }
        public int? Template { get; set; }
        public int? HeaderStationColumnWidth { get; set; }
        public int? HeaderSeqColumnWidth { get; set; }
        public int? HeaderPartColumnWidth { get; set; }
        public int? HeaderTaktColumnWidth { get; set; }
        public int? BoxesColumnWidth { get; set; }
        public int? PartRowHeight { get; set; }
        public int? BoxesRowHeight { get; set; }
        public int? PartNameRowHeight { get; set; }
        public int? QualityAlertRowHeight { get; set; }
        public int? QualityAlertFontSize { get; set; }
        public bool? StationTaktOn { get; set; }
        public bool? StationTaktFirstClickEnabled { get; set; }
        public int? StationTaktTime { get; set; }
        public bool? BarQtyParts { get; set; }
        public bool? BarTimePicking { get; set; }
        public bool? BarPressToMark { get; set; }
        public bool? BarPressToStop { get; set; }
        public int? BarTimeDefault { get; set; }
        public bool? ShowMissingParts { get; set; }
        public bool? StackWagon { get; set; }
        public bool? StackWagonInverseSeq { get; set; }
        public bool? StackWagonShowPopup { get; set; }
        public int? TransitionPart { get; set; }

    }
}