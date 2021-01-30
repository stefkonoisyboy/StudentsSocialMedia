using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Hobbies
{
    public class CreateHobbyInputModel
    {
        public string UserId { get; set; }

        [Required]
        public string HobbyId { get; set; }

        public IEnumerable<SelectListItem> Hobbies { get; set; }
    }
}
