using App2.Models;
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
        List<Test1> testList;
        private List<MobileDataModel> testDictionary;
        public MainPage(List<MobileDataModel> paramContent)
        {
            InitializeComponent();
            testDictionary = paramContent;
            //testList = new List<Test1>();

            //Test1 test1 = new Test1();
            //test1.Name = "Hasan";
            //test1.ImageSource = "emptyCircle.png";
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //testList.Add(test1);
            //Test1 test11 = new Test1();
            //test11.Name = "Hasan";
            //test11.ImageSource = "emptyCircle.png";
            //testList.Add(test11);
            //Test1 test12 = new Test1();
            //test12.Name = "Hasan";
            //test12.ImageSource = "emptyCircle.png";
            //testList.Add(test12);

            this.BindingContext = testDictionary;
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
           
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            try
            {
                if (e.ItemIndex == testList.Count - 1)
                {
                    Console.WriteLine("Liste sonuna gelindi");
                }
            }
            catch (Exception ex)
            {

            }
         
        }

        private void ListView_ItemDisappearing(object sender, ItemVisibilityEventArgs e)
        {

        }

        private void ListView_MeasureInvalidated(object sender, EventArgs e)
        {

        }

        private void ListView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void ListView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }
    }


    public class Test1
    {
        public string Name { get; set; }
        public string ImageSource { get; set; } 


    }
}