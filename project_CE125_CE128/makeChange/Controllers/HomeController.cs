using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using makeChange.Models;
using Microsoft.AspNetCore.Hosting;
using makeChange.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace makeChange.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPetitionRepository _petitionRepository;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly AppDbContext context;


        //[ActivatorUtilitiesConstructor]
        public HomeController(IPetitionRepository petitionRepository,
                              IWebHostEnvironment hostingEnvironment, AppDbContext context)
        {
            _petitionRepository = petitionRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.context = context;
        }


        [HttpGet]
       
        public ViewResult Create()
        {
            return View();
        }

        

        [HttpPost]
        public IActionResult Create(PetitionCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                
                if (model.Photo != null)
                {
                   
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                   
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                String UserName = User.Identity.Name;

                var user = context.Users.Single(x => x.UserName == UserName);
                var id = user.Id;
                Petition newPetition = new Petition
                {
                    Heading = model.Heading,
                    Description = model.Description,
                    // ApplicationUser= context.Users.Single(x => x.UserName == UserName),
                    ApplicationUserId = user.Id,
               // ApplicationUserId=User.Identity
                  
                    PhotoPath = uniqueFileName

            };
                _petitionRepository.Add(newPetition);
                return RedirectToAction("viewpetition", new { PetitionId = newPetition.PetitionId });
            }
            return View();
        }

        private string ProcessUploadedFile(PetitionCreateViewModel model)
        {
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }


        [HttpGet]
       
        public ViewResult Edit(int PetitionId)
        {
            Petition petition = _petitionRepository.GetPetition(PetitionId);
            PetitionEditViewModel petitionEditViewModel = new PetitionEditViewModel
            {
                PetitionId = petition.PetitionId,
                

                Heading = petition.Heading,
                Description = petition.Description,
                ExistingPhotoPath = petition.PhotoPath
            };
            return View(petitionEditViewModel);
        }
                
        [HttpPost]
       
        public IActionResult Edit(PetitionEditViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                
                Petition Petition = _petitionRepository.GetPetition(model.PetitionId);
               
                Petition.Heading = model.Heading;
                Petition.Description = model.Description;
               

               
                if (model.Photo != null)
                {
                    
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                            "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    
                    Petition.PhotoPath = ProcessUploadedFile(model);
                }

               
                Petition updatedPetition = _petitionRepository.Update(Petition);

                return RedirectToAction("index");
            }

            return View(model);
        }


        [HttpGet]
        public IActionResult Delete(int PetitionId)
        {
            Petition petition= _petitionRepository.GetPetition(PetitionId);


            if(petition == null)
            {
                Response.StatusCode = 404;
                return View("PetitionNotFound", PetitionId);
            }
            return View(petition);
        }
        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int PetitionId)
        {
            Petition petition = _petitionRepository.GetPetition(PetitionId);

            _petitionRepository.Delete(petition.PetitionId);

            return RedirectToAction("index","Home");

        }

        [AllowAnonymous]
        public ViewResult ViewPetition(int PetitionId)
        {
            Petition petition = _petitionRepository.GetPetition(PetitionId);
            Console.WriteLine(PetitionId);
            if (petition == null)
            {
                Response.StatusCode = 404;
                return View("PetitionNotFound", PetitionId);
            }
            String UserName = User.Identity.Name;

            var user = context.Users.Single(x => x.UserName == UserName);
            HomeViewPetitionViewModel homeViewPetitionViewModel = new HomeViewPetitionViewModel()
            {
                Petition = petition,
                PageTitle = "Petition",
                Count = _petitionRepository.TotalCount(PetitionId),
                IsOwner = _petitionRepository.IsOwner(user),
                IsSigned = _petitionRepository.IsSigned(user),
            };
            // Pass the ViewModel object to the View() helper method
            return View(homeViewPetitionViewModel);
        }

        // private readonly ILogger<HomeController> _logger;

        /* public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         }*/

        [AllowAnonymous]
        public ViewResult Index()
        {
            // retrieve all the Staffs
            var model = _petitionRepository.GetAllPetitions();
            // Pass the list of Staffs to the view

            return View(model);
        }

        
        public ViewResult Mypetition()
        {
            String UserName = User.Identity.Name;

            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;
            var model = _petitionRepository.GetMyPetitions(user);
            // Pass the list of Staffs to the view
            return View(model);
        }


        public IActionResult SignThePetition(int PetitionId)
        {
            String UserName = User.Identity.Name;

            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;
            var petition = context.Petitions.Single(x=>x.PetitionId==PetitionId);
            ApplicationUserPetition newApp = new ApplicationUserPetition
            {
                ApplicationUser = user,
                ApplicationUserId = user.Id,
                PetitionId = PetitionId,
                Petition = petition
            };

            context.ApplicationUserPetitions.Add(newApp);
            context.SaveChanges();

            return RedirectToAction("SignedPetitions", "Home");
        }
        public ViewResult SignedPetitions()
        {
            String UserName = User.Identity.Name;

            var user = context.Users.Single(x => x.UserName == UserName);
            var id = user.Id;
            var model = _petitionRepository.GetSignedPetitions(user);
            
            return View(model);


        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
