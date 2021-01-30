using StudentsSocialMedia.Web.ViewModels.Home;
using StudentsSocialMedia.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public interface IPostsService
    {
        IEnumerable<T> GetAll<T>();

        IEnumerable<T> GetAllById<T>(string id);

        Task CreateAsync(CreatePostInputModel input);
    }
}
