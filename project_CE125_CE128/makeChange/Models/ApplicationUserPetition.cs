using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.Models
{
    public class ApplicationUserPetition
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int PetitionId { get; set; }

        public Petition Petition { get; set; }
    }
}
