using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.core;
using WpfApp1.mvvm.viemodel;

namespace WpfApp1.mvvm.viewmodel
{
     class MainViewModel:observableobject
     {      
        public HomeViewModel HomeVm { get; set; }
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
            OnPropertyChanged();}
        }
        public MainViewModel()
        {
            HomeVm=new HomeViewModel();
            CurrentView = HomeVm;

        }
    }
}
