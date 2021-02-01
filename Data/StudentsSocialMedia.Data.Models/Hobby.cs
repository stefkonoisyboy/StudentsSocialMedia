using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class Hobby : BaseDeletableModel<string>
    {
        public Hobby()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Users = new HashSet<UserHobby>();
        }

        public string Name { get; set; }

        public virtual ICollection<UserHobby> Users { get; set; }
    }
}
