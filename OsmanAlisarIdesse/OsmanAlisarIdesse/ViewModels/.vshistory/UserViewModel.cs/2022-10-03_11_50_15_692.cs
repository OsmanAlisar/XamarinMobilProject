using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace OsmanAlisarIdesse.ViewModels
{
    internal class UserViewModel:INotifyPropertyChanged
    {
        private User _loginUser;
        public User LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value;
                OnPropertyChange(nameof(LoginUser));
            }
        }

        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }

        private ServiceManager sManager;

        public event PropertyChangedEventHandler PropertyChanged;

        public UserViewModel()
        {
            sManager = new ServiceManager();
            this.LoginUser = (User)sManager.GetUserMobile().Result.ResultData;
        }

    }
}
