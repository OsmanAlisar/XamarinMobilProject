using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OsmanAlisarIdesse.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
   
            ServiceManager sm = new ServiceManager();
            SMResult result = null;
            if (txtUserName.Text != "" & txtPassword.Text != "")
            {
                result = sm.Login(txtUserName.Text,txtPassword.Text).Result;

            }
            if (result != null)
            {
                Dictionary<string, string> responseData = (Dictionary<string, string>)result.ResultData;
                if (responseData["success"] == "true")
                {
                    var bilgiler = sm.GetUserMobile();
                    Navigation.PushModalAsync(new Menu {men });
                    //List<MobileDataModel> mobileList = (List<MobileDataModel>)sm.GetListMobile(20, 0, true).Result.ResultData;
                    //Navigation.PushModalAsync(new MainPage(mobileList), true);

                }

            }
           
        }
    }
}