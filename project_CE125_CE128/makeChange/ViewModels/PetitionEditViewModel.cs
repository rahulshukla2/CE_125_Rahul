using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.ViewModels
{
    public class PetitionEditViewModel : PetitionCreateViewModel
    {
        public int PetitionId { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
