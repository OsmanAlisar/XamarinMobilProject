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
    }
}
