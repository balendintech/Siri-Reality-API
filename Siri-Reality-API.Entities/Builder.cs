using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Siri_Reality_API.Entities
{
    public class Builder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string City { get; set; }
        public string OfficeAddress { get; set; }
        [Required]
        public int AssetId { get; set; }
        public virtual Asset Asset { get; set; } = new Asset();
        public int YearOfEstablishment { get; set; }
        public ICollection<ContactPerson> ContactPersons { get; set; } = new List<ContactPerson>();
        //[AllowHtml]
        public string Descripion { get; set; }
    }
}
