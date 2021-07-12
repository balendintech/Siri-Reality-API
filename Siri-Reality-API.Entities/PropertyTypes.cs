using System.ComponentModel.DataAnnotations;

namespace Siri_Reality_API.Entities
{
    public class PropertyTypes
    {
        [Key]
        public int PropertyTypeId { get; set; }
        public string Title { get; set; }
    }
}
