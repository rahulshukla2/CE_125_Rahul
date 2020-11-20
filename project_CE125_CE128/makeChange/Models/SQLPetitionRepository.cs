using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.Models
{
    public class SQLPetitionRepository : IPetitionRepository
    {
        private readonly AppDbContext context;
        public SQLPetitionRepository(AppDbContext context)
        {
            this.context = context;
        }


        Petition IPetitionRepository.Add(Petition petition)
        {
            context.Petitions.Add(petition);
            context.SaveChanges();
            return petition;
        }
        Petition IPetitionRepository.Delete(int PetitionId)
        {
            Petition petition = context.Petitions.Find(PetitionId);
            if (petition != null)
            {
                context.Petitions.Remove(petition);
                context.SaveChanges();
            }
            return petition;
        }

        Petition IPetitionRepository.Update(Petition petitionedit)
        {
            var petition = context.Petitions.Attach(petitionedit);
            petition.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return petitionedit;
        }


        Petition IPetitionRepository.GetPetition(int PetitionId)
        {
            return context.Petitions.Find(PetitionId);
        }


        IEnumerable<Petition> IPetitionRepository.GetAllPetitions()
        {
            return context.Petitions;
        }

        public int TotalCount(int PetitionId)
        {
             return context.ApplicationUserPetitions.Where(x => x.PetitionId == Convert.ToInt32(PetitionId)).Count();
           // var list = (IList<ApplicationUserPetition>)context.ApplicationUserPetitions.Where(x => x.ApplicationUserId.Equals(id)).ToList();
        }


        public bool IsOwner(ApplicationUser user)
        {

            var a = context.Petitions.Where(x => x.ApplicationUserId.Equals(user.Id));

            if (a == null)
                return false;
            else
                return true;
        }

        public bool IsSigned(ApplicationUser user)
        {
            var a = context.ApplicationUserPetitions.Where(x => x.ApplicationUserId.Equals(user.Id));
            if (a == null)
                return false;
            else
                return true;

        }
        IEnumerable<Petition> IPetitionRepository.GetMyPetitions(ApplicationUser User)
        {
            String UserName = User.UserName;
            
            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;
            return context.Petitions.Where(x => x.ApplicationUserId.Equals(id)).ToList();
               
        }

        IEnumerable<Petition> IPetitionRepository.GetSignedPetitions(ApplicationUser User)
        {
            String UserName = User.UserName;

            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;
            var list= (IList<ApplicationUserPetition>)context.ApplicationUserPetitions.Where(x => x.ApplicationUserId.Equals(id)).ToList();
            //(x => x.ApplicationUserId == id);iwjj
            List<Petition> list1 = new List<Petition>();
            foreach(var app in list)
            {
                //Petition pet = (Petition)context.Petitions.Where(x => x.PetitionId == app.PetitionId);
                Petition pet = context.Petitions.Find(app.PetitionId);
                list1.Add(pet);
            }
            return list1;
        }

    }
}
