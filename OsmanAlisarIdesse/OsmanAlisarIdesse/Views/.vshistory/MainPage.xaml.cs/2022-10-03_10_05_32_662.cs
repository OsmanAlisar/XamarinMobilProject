using OsmanAlisarIdesse.Models;
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
    public partial class MainPage : ContentPage
    {
        private List<MobileDataModel> testDictionary;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = testDictionary;
        }
        private void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            try
            {
                if (e.ItemIndex == testDictionary.Count - 1)
                {
                    Console.WriteLine("Liste sonuna gelindi");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }

}