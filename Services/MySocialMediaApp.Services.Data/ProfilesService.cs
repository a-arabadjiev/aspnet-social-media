namespace MySocialMediaApp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MySocialMediaApp.Data.Common.Repositories;
    using MySocialMediaApp.Data.Models;

    public class ProfilesService : IProfilesService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public ProfilesService(IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public bool DoesUserExist(string username)
        {
            // TODO: make async
            return this.usersRepository.AllAsNoTracking().Any(u => u.UserName == username);
        }
    }
}
