using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace OsmanAlisarIdesse.Views
{
    [Obsolete]
    public class MyMasterPage:MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new Menu();
            Detail = new MainPage();
        }
    }
}
