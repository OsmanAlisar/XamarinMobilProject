using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OsmanAlisarIdesse.ViewModels
{
    internal class MainPageViewModel
    {
        private ObservableCollection<MobileDataModel> personList;
        ICommand itemAppearing;
        public MainPageViewModel()
        {
            service = new ServiceManager();
            itemAppearing = new Command(OnAppearing);
            PersonList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData;

        }
        public ObservableCollection<MobileDataModel> PersonList
        {
            get
            {
                if (personList == null)
                    personList = new ObservableCollection<MobileDataModel>();
                return personList; 
            }
            set { personList = value; }
        }
        public ICommand ItemAppearing
        {
            get { return itemAppearing; }
            set {
                if (itemAppearing == null)
                {
                    return;
                }
                itemAppearing = value; }
        }
        private void OnAppearing(object param)
        {

        }

        private ServiceManager service;
       

    }
}
