namespace MySocialMediaApp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProfilesService
    {
        bool DoesUserExist(string username);
    }
}
