using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace OsmanAlisarIdesse.ViewModels
{
    internal class MainPageViewModel
    {
        private ObservableCollection<MobileDataModel> personList;
        ICommand itemAppearing;
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
            set { itemAppearing = value; }
        }

        private ServiceManager service;
        public MainPageViewModel()
        { 
            service = new ServiceManager();
            PersonList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData;
           
        }

    }
}
