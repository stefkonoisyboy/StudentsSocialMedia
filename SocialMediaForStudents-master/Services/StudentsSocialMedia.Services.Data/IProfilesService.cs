using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface IProfilesService
    {
        T GetAbout<T>(string id);
    }
}
