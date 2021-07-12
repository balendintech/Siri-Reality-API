using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Siri_Reality_API.Entities
{
    public class ContactPerson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int AssetId { get; set; }
        public virtual Asset Asset { get; set; }
        public bool IsAgent { get; set; }
        [Required]
        public int BuilderId { get; set; }
        public virtual Builder Builder { get; set; }
        [DataType(DataType.Date)]
        public DateTime? JoiningDate { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string Linkedin { get; set; }
    }
}
