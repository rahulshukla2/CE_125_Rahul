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

        /*private readonly AppDbContext context;

        
        [ActivatorUtilitiesConstructor]
        public HomeViewPetitionViewModel()
        {

        }*/
       /* public HomeViewPetitionViewModel(AppDbContext context)
        {
            
            this.context = context;
        }*/

        /*public bool IsOwner(ApplicationUser User,int PetitionId)
        {
            String UserName = User.UserName;

            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;
           Petition p1 = (Petition)context.Petitions.Where(x => x.PetitionId == PetitionId);
            if (p1.ApplicationUserId.Equals(id))
                return true;
            else
                return false;
        }

        public bool IsSigned(ApplicationUser User,int PetitionId,)
        {
            String UserName = User.UserName;

            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;

            ApplicationUserPetition app =(ApplicationUserPetition) context.ApplicationUserPetitions.Where(x => x.PetitionId.Equals(PetitionId));

            if (app.ApplicationUserId.Equals(id))
                return true;
            else
                return false;
        }*/
    }
}
