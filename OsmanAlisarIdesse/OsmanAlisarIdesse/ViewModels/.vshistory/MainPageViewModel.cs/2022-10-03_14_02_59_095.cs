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
         /*   PersonList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData*/;
            foreach (var prs in service.GetListMobile(20, 0, false).Result.ResultData)
            {

            }
        }
        public ObservableCollection<MobileDataModel> getObservalCollection(string filter = "")
        {
            ObservableCollection<MobileDataModel> customList = new ObservableCollection<MobileDataModel>();

            return customList;
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
            if (int.Parse(param.ToString()) == PersonList.Count -1)
            {
                ObservableCollection<MobileDataModel> continueList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, int.Parse(param.ToString()), false).Result.ResultData;
                foreach (var prs in continueList)
                {
                    personList.Add(prs);
                }
            }
        }

        private ServiceManager service;
       

    }
}
