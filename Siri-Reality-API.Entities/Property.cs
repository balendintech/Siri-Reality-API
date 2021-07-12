using Siri_Reality_API.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siri_Reality_API.Entities
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string PropertyDescripion { get; set; }
        public string PropertyAddress { get; set; }
        public string Location { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        public string PinCode { get; set; }
        public string LandMark { get; set; }
        public string PropertyMap { get; set; }
        public double PropertyAmount { get; set; }
        [EnumDataType(typeof(PropertyCategory))]
        public PropertyCategory PropertyCategory { get; set; }
        [Required]
        public int PropertyTypeId { get; set; }
        public virtual PropertyTypes PropertyType { get; set; }
        public bool TrendingProject { get; set; }
        public bool SpotlightProject { get; set; }
        public bool FeaturedProject { get; set; }
        public double Area { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PossessionDate { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public string VideoLink { get; set; }
        [Required]
        public int BuilderId { get; set; }
        public virtual Builder Builder { get; set; }
        [Required]
        public int ContactPersonId { get; set; }
        public virtual ContactPerson ContactPerson { get; set; }
        public int? Asset_Id { get; set; }
        public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
        public virtual Asset Asset { get; set; }
        [Required]
        public int PropertyConditionId { get; set; }
        [ForeignKey("PropertyConditionId")]
        public virtual PropertyConditions PropertyConditions { get; set; }
        [Required]
        public int PropertyFeaturesId { get; set; }
        [ForeignKey("PropertyFeaturesId")]
        public virtual PropertyFeatures PropertyFeatures { get; set; }
        public string PropertyAge { get; set; }
        public double EMI { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public double PriceRange { get; set; }
    }
}
