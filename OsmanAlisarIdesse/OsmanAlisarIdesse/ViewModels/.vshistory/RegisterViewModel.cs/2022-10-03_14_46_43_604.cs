using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
namespace OsmanAlisarIdesse.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _surName;
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
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }
    }
}
