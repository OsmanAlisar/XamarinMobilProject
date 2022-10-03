using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OsmanAlisarIdesse.ViewModels
{
    public class RegisterViewModel: INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange([CallerMemberName] string proppertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proppertyName));
        }

    }
}
