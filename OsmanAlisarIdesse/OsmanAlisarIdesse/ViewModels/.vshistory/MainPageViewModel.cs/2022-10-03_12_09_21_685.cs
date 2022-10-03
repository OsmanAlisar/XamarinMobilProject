using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Provider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OsmanAlisarIdesse.ViewModels
{
    internal class MainPageViewModel
    {
        private ObservableCollection<MobileDataModel> personList;
        public ObservableCollection<MobileDataModel> PersonList { get => personList; set => personList = value; }

        private ServiceManager service;
        public MainPageViewModel()
        { 
            service = new ServiceManager();
            PersonList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData;
        }

    }
}
