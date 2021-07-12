using Siri_Reality_API.Entities.Enums;
using System;

namespace Siri_Reality_API.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public FileType Types { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public string VideoLink { get; set; }
    }
}
