using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.ViewModels
{
    public class PetitionCreateViewModel
    {

        [Required]
        public string Heading { get; set; }
        [Required]
        public IFormFile Photo { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
