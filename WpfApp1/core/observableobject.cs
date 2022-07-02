using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.core
{
    internal class observableobject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
