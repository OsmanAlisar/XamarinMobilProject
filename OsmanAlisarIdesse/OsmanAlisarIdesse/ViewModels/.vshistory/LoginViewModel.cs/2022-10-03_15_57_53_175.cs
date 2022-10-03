using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OsmanAlisarIdesse.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        private string _userName;
        private string _password;
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
