using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Data;
using StudentsSocialMedia.Web.ViewModels.Followers;
using StudentsSocialMedia.Web.ViewModels.Images;
using StudentsSocialMedia.Web.ViewModels.Posts;
using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Web.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IImagesService imagesService;
        private readonly IFollowersService followersService;
        private readonly IUsersService usersService;
        private readonly IProfilesService profilesService;
        private readonly UserManager<ApplicationUser> userManager;

        public ProfilesController(
            IPostsService postsService,
            IImagesService imagesService,
            IFollowersService followersService,
            IUsersService usersService,
            IProfilesService profilesService,
            UserManager<ApplicationUser> userManager)
        {
            this.postsService = postsService;
            this.imagesService = imagesService;
            this.followersService = followersService;
            this.usersService = usersService;
            this.profilesService = profilesService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Timeline(string id)
        {
            ProfileViewModel viewModel = new ProfileViewModel
            {
                UserInfo = this.usersService.GetById<UserViewModel>(id),
                Posts = this.postsService.GetAllById<AllPostsViewModel>(id),
                LastPhotos = this.imagesService.GetAllById<AllImagesViewModel>(id),
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult About(string id)
        {
            AboutViewModel viewModel = this.profilesService.GetAbout<AboutViewModel>(id);

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult Friends(string id)
        {
            return this.View();
        }
    }
}
