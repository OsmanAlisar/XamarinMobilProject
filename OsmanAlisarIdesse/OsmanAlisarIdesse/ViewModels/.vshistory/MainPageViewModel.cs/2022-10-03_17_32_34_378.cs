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
        private static ObservableCollection<MobileDataModel> personList;
        public static List<MobileDataModel> prsList = new List<MobileDataModel>();
        ICommand textChange;
        ICommand itemAppearing;


        public MainPageViewModel()
        {
            service = new ServiceManager();
            itemAppearing = new Command(OnAppearing);
            textChange = new Command(OnTextChange);
            prsList = (List<MobileDataModel>)service.GetListMobile(20, 0, false).Result.ResultData;
            foreach (var prs in prsList)
            {
                PersonList.Add(prs);
            }
        }
        public static void SetPrsListToObserval(List<MobileDataModel> modelList)
        {
            PersonList.Clear();
            foreach (var prs in modelList)
            {
                personList.Add(prs);
            }
        }
        public  void GetObservalCollection(string filter = "")
        {
            if (filter != "")
            {
                SetPrsListToObserval(prsList.FindAll(o => o.CardName.ToLower().Contains(filter.ToLower())));
            }
            else
            {
                SetPrsListToObserval(prsList);
            }
        }
        public static  ObservableCollection<MobileDataModel> PersonList
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
            set
            {
                if (itemAppearing == null)
                {
                    return;
                }
                itemAppearing = value;
            }
        }
        public ICommand TextChange
        {
            get { return textChange; }
            set
            {
                if (textChange == null)
                {
                    return;
                }
                textChange = value;
            }
        }
        public void OnTextChange(object param)
        {
            var paramFilter = param.ToString();
            if (paramFilter.Length>2)
            {
                GetObservalCollection(paramFilter);
            }
            else if (paramFilter == "")
            {
                GetObservalCollection();
            }
        }
        private void OnAppearing(object param)
        {
            if (int.Parse(param.ToString()) == PersonList.Count - 1)
            {

                prsList.AddRange((List<MobileDataModel>)service.GetListMobile(20, int.Parse(param.ToString()), false).Result.ResultData);
                //ObservableCollection<MobileDataModel> continueList = (ObservableCollection<MobileDataModel>)service.GetListMobile(20, int.Parse(param.ToString()), false).Result.ResultData;
                GetObservalCollection();
            }
        }

        private ServiceManager service;


    }
}
