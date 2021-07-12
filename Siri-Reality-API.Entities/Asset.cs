using Siri_Reality_API.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Siri_Reality_API.Entities
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        public string AssetPath { get; set; }
        public string AssetName { get; set; }
        public bool IsDefault { get; set; }
        public AssestType AssetsType { get; set; }
        public AssestCatgoery AssetsCategeroy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? PropertyId { get; set; }
        public virtual Property Property { get; set; }
    }
}
