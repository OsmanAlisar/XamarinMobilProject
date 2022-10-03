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
        private IEnumerable<MobileDataModel> personList;
        ICommand itemAppearing;
        public MainPageViewModel()
        {
            service = new ServiceManager();
            itemAppearing = new Command(OnAppearing);
            PersonList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData;
      
        }
        public IEnumerable<MobileDataModel> PersonList
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
                List<MobileDataModel> lst = (List<MobileDataModel>)PersonList;
                lst.AddRange(continueList);
                //foreach (var prs in continueList)
                //{
                //   lst.
                //}
            }
        }

        private ServiceManager service;
       

    }
}
