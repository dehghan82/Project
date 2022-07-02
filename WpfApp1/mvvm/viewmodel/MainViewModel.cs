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
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ProfileViewCommand { get; set; }
        public HomeViewModel HomeVm { get; set; }
        public Profileviewmodel proVm { get; set; }
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
            proVm=new Profileviewmodel();
            CurrentView = HomeVm;
            HomeViewCommand = new RelayCommand(o =>
              {
                  CurrentView = HomeVm;
              });
            ProfileViewCommand = new RelayCommand(o =>
            {
                CurrentView = proVm;
            });

        }
    }
}
