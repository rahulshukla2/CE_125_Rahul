using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.Models
{
    public interface IPetitionRepository
    {
        Petition GetPetition(int PetitionId);

        IEnumerable<Petition> GetAllPetitions();

        IEnumerable<Petition> GetMyPetitions(ApplicationUser user);

        IEnumerable<Petition> GetSignedPetitions(ApplicationUser User);

        int TotalCount(int PetitionId);

        bool IsOwner(ApplicationUser user);

        bool IsSigned(ApplicationUser user);
        Petition Add(Petition petition);

        Petition Update(Petition petition);

        Petition Delete(int PetitionId);


        /*Staff GetStaff(int Id);
        IEnumerable<Staff> GetAllStaffs();
        Staff Add(Staff staff);
        Staff Update(Staff staffChanges);
        Staff Delete(int Id);*/
    }
}
