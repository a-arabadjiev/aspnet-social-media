using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySocialMediaApp.Services.Data
{
    public interface IProfilesService
    {
        bool DoesUserExist(string username);
    }
}
