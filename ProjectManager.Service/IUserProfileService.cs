using ProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(string id);
    }
}
