using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace OsmanAlisarIdesse.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _surName;
        ICommand onRegister;
        public event PropertyChangedEventHandler PropertyChanged;
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
        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }
}
