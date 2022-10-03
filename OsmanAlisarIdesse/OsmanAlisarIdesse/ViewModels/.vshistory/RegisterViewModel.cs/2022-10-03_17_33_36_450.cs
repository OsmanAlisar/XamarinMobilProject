using OsmanAlisarIdesse.Models;
using OsmanAlisarIdesse.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OsmanAlisarIdesse.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _surName;
        public event PropertyChangedEventHandler PropertyChanged;
        ICommand onRegister;
        public RegisterViewModel()
        {
            onRegister = new Command(OnRegister);
         
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange(nameof(Name));
            }
        }
        public string SurName
        {
            get { return _surName; }
            set
            {
                _surName = value;
                OnPropertyChange(nameof(SurName));
            }
        }
        public ICommand Register
        {
            get { return onRegister; }
            set
            {
                if (onRegister == null)
                {
                    return;
                }
                onRegister = value;
            }
        }
        public void OnRegister(object param)
        {
            MobileDataModel newUser = new MobileDataModel();
            newUser.CardName = Name + " " + SurName;
            MainPageViewModel.prsList.Add(newUser);
            MainPageViewModel.get
            
        }

   

  
        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }
}
