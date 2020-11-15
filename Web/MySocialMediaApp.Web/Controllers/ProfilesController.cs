using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySocialMediaApp.Services.Data;

namespace MySocialMediaApp.Web.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly IProfilesService profilesService;

        public ProfilesController(IProfilesService profilesService)
        {
            this.profilesService = profilesService;
        }

        [Route("Profiles/{username}")]
        public IActionResult Index(string username)
        {
            if (!this.profilesService.DoesUserExist(username))
            {
                return this.NotFound();
            }

            return this.View();
        }
    }
}
