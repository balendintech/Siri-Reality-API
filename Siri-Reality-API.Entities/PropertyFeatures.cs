using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Siri_Reality_API.Entities
{
    public class PropertyFeatures
    {
        [Key]
        public int Id { get; set; }
        public bool IsAC { get; set; }
        public bool IsWifi { get; set; }
        public bool IsSwimmingpool { get; set; }
        public bool IsIntercom { get; set; }
        public string NoOfParking { get; set; }
        public bool IsHomeTheater { get; set; }
        public bool IsAlarm { get; set; }
        public bool IsSecurity { get; set; }
        public bool IsGym { get; set; }
        public bool IsClub { get; set; }
        public bool IsGenerator { get; set; }
        public bool IsPark { get; set; }
        public bool Iswalkingtrack { get; set; }
        public bool IsBorewell { get; set; }
    }
}
