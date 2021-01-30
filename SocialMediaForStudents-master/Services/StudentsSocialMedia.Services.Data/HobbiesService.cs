using Microsoft.AspNetCore.Mvc.Rendering;
using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Hobbies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public class HobbiesService : IHobbiesService
    {
        private readonly IDeletableEntityRepository<Hobby> hobbiesRepository;
        private readonly IDeletableEntityRepository<UserHobby> userHobbiesRepository;

        public HobbiesService(IDeletableEntityRepository<Hobby> hobbiesRepository, IDeletableEntityRepository<UserHobby> userHobbiesRepository)
        {
            this.hobbiesRepository = hobbiesRepository;
            this.userHobbiesRepository = userHobbiesRepository;
        }

        public async Task Create(CreateHobbyInputModel input)
        {
            UserHobby userHobby = new UserHobby
            {
                UserId = input.UserId,
                HobbyId = input.HobbyId,
            };

            await this.userHobbiesRepository.AddAsync(userHobby);
            await this.userHobbiesRepository.SaveChangesAsync();
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            IEnumerable<SelectListItem> hobbies = this.hobbiesRepository
                .All()
                .Select(h => new SelectListItem
                {
                    Text = h.Name,
                    Value = h.Id,
                })
                .ToList();

            return hobbies;
        }

        public IEnumerable<T> GetAllById<T>(string id)
        {
            IEnumerable<T> hobbies = this.userHobbiesRepository
                .All()
                .Where(uh => uh.UserId == id)
                .To<T>()
                .ToList();

            return hobbies;
        }
    }
}
