using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.Text;

namespace OsmanAlisarIdesse.ViewModels
{
    internal class UserViewModel
    {
        private User LoginUser;
        private ServiceManager sManager;
        public UserViewModel()
        {
            sManager = new ServiceManager();
            this.user = (User)sManager.GetUserMobile().Result.ResultData;
        }

    }
}
