using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace OsmanAlisarIdesse.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        private string _userName;
        private string _password;
        public string UserName { get { return _userName; } set { _userName = value; OnPropertyChange(nameof(UserName)); } }
        public string Password { get { return _password; } set { _password = value; OnPropertyChange(nameof(Password)); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }

}
