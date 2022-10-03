using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using OsmanAlisarIdesse.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace OsmanAlisarIdesse.ViewModels
{
    internal class UserViewModel : INotifyPropertyChanged
    {
        private User _loginUser;
        private ServiceManager sManager;
        public event PropertyChangedEventHandler PropertyChanged;
        ICommand onRegister;
        public UserViewModel()
        {
            sManager = new ServiceManager();
            this.LoginUser = (User)sManager.GetUserMobile().Result.ResultData;
            onRegister = new Command(OnRegisterMenu);
        }
        public ICommand RegisterMenu
        {
            get { return onRegister; }
            set
            {
                if (onRegister == null)
                {
                    return;
                }
                onRegister = value;
            }
        }

        [Obsolete]
        private void OnRegisterMenu(object param)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new Register());
        }
        public User LoginUser
        {
            get { return _loginUser; }
            set
            {
                _loginUser = value;
                OnPropertyChange(nameof(LoginUser));
            }
        }
        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }
}
