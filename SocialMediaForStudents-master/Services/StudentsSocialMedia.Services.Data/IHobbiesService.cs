using Microsoft.AspNetCore.Mvc.Rendering;
using StudentsSocialMedia.Web.ViewModels.Hobbies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public interface IHobbiesService
    {
        IEnumerable<SelectListItem> GetAll();

        IEnumerable<T> GetAllById<T>(string id);

        Task Create(CreateHobbyInputModel input);
    }
}
