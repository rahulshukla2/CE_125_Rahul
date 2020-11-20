using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        public Gender Gender { get; set; }

        public ICollection<Petition> Petitions { get; set; }

        public IList<ApplicationUserPetition> ApplicationUserPetitions { get; set; }
    }
}
