using Siri_Reality_API.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Siri_Reality_API.Entities
{
    public class PropertyConditions
    {
        [Key]
        public int Id { get; set; }
        public string NoOfBeds { get; set; }
        public string NoOfGarage { get; set; }
        public string NoofBathrooms { get; set; }
        public string NoofBalcony { get; set; }

        [EnumDataType(typeof(PropertyFacing))]
        public PropertyFacing PropertyFacing { get; set; }

        [EnumDataType(typeof(PropertyFurnished))]
        public PropertyFurnished PropertyFurnished { get; set; }
    }
}
