using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Hobbies
{
    public class AllHobbiesByIdViewModel : IMapFrom<UserHobby>
    {
        public string HobbyName { get; set; }
    }
}
