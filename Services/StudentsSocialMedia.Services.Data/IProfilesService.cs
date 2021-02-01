using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public interface IProfilesService
    {
        T GetAbout<T>(string id);

        Task UpdateAsync(string id, EditProfileInputModel input);
    }
}
