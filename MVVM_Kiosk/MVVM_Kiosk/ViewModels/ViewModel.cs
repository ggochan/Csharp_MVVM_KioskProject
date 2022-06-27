using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Kiosk.Models;
using MVVM_Kiosk.Commands;
using System.Collections.ObjectModel;

namespace MVVM_Kiosk.ViewModels
{
    class ViewModel : MenuBase
    {
        public ICommand MenuAddCommand => new RelayCommand<object>(Excuted, CanExecuted);

        public ObservableCollection<Menu> Menu_ { get; set; }

        private int total_ = 0;

        public int Total
        {
            get { return this.total_; }
            set
            {
                this.total_ = value;
                this.OnPropertyChanged("Total");
            }
        }
        public ViewModel()
        {
            this.Menu_ = new ObservableCollection<Menu>();

            this.Menu_.Add(new Menu { Name = "아메리카노", Price = 1500 });
            this.Menu_.Add(new Menu { Name = "카페라떼", Price = 2000 });
            this.Menu_.Add(new Menu { Name = "녹차라떼", Price = 2500 });
            this.Menu_.Add(new Menu { Name = "큐브라떼", Price = 3000 });
            this.Menu_.Add(new Menu { Name = "메가초코프라페", Price = 3500 });
            this.Menu_.Add(new Menu { Name = "로얄밀크티", Price = 2500 });
            this.Menu_.Add(new Menu { Name = "고구마라떼", Price = 3000 });
            this.Menu_.Add(new Menu { Name = "카페모카", Price = 2500 });
            this.Menu_.Add(new Menu { Name = "티라미수라떼", Price = 3000 });
            this.Menu_.Add(new Menu { Name = "카라멜 마끼아또", Price = 3000 });
        }
        private void Excuted(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanExecuted(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
