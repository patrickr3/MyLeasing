using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        [Display(Name ="Document")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters!")]
        [Required(ErrorMessage = "The field {0} is mandatory!")]
        public string Document { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(25)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(25)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [Display(Name = "Lessee Name")]
        public string FullName => $"{FirstName} {LastName}";
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
        public ICollection<Contract> Contracts { get; set; }
    }
}
