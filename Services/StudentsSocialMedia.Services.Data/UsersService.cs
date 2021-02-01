using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public UsersService(IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public T GetById<T>(string id)
        {
            T user = this.usersRepository
                .All()
                .Where(u => u.Id == id)
                .To<T>()
                .FirstOrDefault();

            return user;
        }
    }
}
