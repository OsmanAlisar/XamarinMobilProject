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
        private List<MobileDataModel> prsList;
        ICommand itemAppearing;

        
        public MainPageViewModel()
        {
            service = new ServiceManager();
            itemAppearing = new Command(OnAppearing);
            prsList = (List<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData;
            foreach (var prs in prsList)
            {
                PersonList.Add(prs);
            }
        }
        public void SetPrsListToObserval(List<MobileDataModel> modelList)
        {
            PersonList.Clear();
            foreach (var prs in modelList)
            {
                personList.Add(prs);
            }
        }
        public GetObservalCollection(string filter = "")
        {
            if (filter != "")
            {

            }
            else
            {
                SetPrsListToObserval(this.prsList);
            }
 

        
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

                this.prsList.AddRange((List<MobileDataModel>)service.GetListMobile(20, int.Parse(param.ToString()), false).Result.ResultData);
                //ObservableCollection<MobileDataModel> continueList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, int.Parse(param.ToString()), false).Result.ResultData;
                GetObservalCollection();
            }
        }

        private ServiceManager service;
       

    }
}
