using makeChange.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.ViewModels
{
    public class HomeViewPetitionViewModel
    {
        public Petition Petition { get; set; }
        public string PageTitle { get; set; }

        public int Count { get; set; }
        public bool IsOwner { get; set; }

        public bool IsSigned { get; set; }

        
    }
}
