using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterHierarchyView
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public string CounterNumber { get; set; }
        public string CounterName { get; set; }
        public string TypeCounterName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public long ParentHouseCounterId { get; set; }
        public string ParentcounterName { get; set; }
        public string ParentTypeCounterName { get; set; }
        public DateTime ParentCounterFromDate { get; set; }
        public DateTime? ParentCounterToDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string AdressName { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
