using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfRavRobot.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nameProperty = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }

        public virtual void Dispose()
        {

        }
    }
}
