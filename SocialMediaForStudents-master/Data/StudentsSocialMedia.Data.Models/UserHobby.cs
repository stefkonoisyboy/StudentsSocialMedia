using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class UserHobby : BaseDeletableModel<string>
    {
        public UserHobby()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string HobbyId { get; set; }

        public virtual Hobby Hobby { get; set; }
    }
}
