using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OsmanAlisarIdesse.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _userName;
        private string _password;
        ICommand onLogin;
        public string UserName { get { return _userName; } set { _userName = value; OnPropertyChange(nameof(UserName)); } }
        public string Password { get { return _password; } set { _password = value; OnPropertyChange(nameof(Password)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        ServiceManager sm = new ServiceManager();
        SMResult result = null;
        public LoginViewModel()
        {
            onLogin = new Command(OnLoginEvent);
        }

        public ICommand Onlogin
        {
            get { return onLogin; }
            set
            {
                if (onLogin == null)
                    return;
                onLogin = value;
            }
        }
        public void OnLoginEvent(object param)
        {

            if (txtUserName.Text != "" & txtPassword.Text != "")
            {
                result = sm.Login(txtUserName.Text, txtPassword.Text).Result;

            }
            if (result != null)
            {
                Dictionary<string, string> responseData = (Dictionary<string, string>)result.ResultData;
                if (responseData["success"] == "true")
                {
                    var bilgiler = sm.GetUserMobile();
                    Navigation.PushModalAsync(new MyMasterPage());
                    //List<MobileDataModel> mobileList = (List<MobileDataModel>)sm.GetListMobile(20, 0, true).Result.ResultData;
                    //Navigation.PushModalAsync(new MainPage(mobileList), true);

                }

            }
        }
        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }

}
