using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [MaxLength(25)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        public User User { get; set; }

        public ICollection<Property> Properties { get; set; }
        public ICollection<Contract> Contracts { get; set; }

    }
}
