using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.Models
{
    public class Petition
    {
        public int PetitionId { get; set; }

        [Required]
        public string Heading { get; set; }
        [Required]
        public string PhotoPath { get; set; }

        [Required]
        public string Description { get; set; }

        public String ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public IList<ApplicationUserPetition> ApplicationUserPetitions {get; set;}

    }
}
