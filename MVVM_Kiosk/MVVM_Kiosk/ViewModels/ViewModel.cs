using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Kiosk.Models;
using MVVM_Kiosk.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace MVVM_Kiosk.ViewModels
{
    class ViewModel : MenuBase
    {
        #region Window Close
        public Action CloseAction { get; set; } // Close Action 호출

        int btnCount = 0; // button 호출 Count
        #endregion

        #region RelayCommand
        // RelayCommand
        /*public ICommand MenuAddCommand => new RelayCommand<object>(Excuted, CanExecuted);
       private void Excuted(object obj)
       {
           throw new NotImplementedException();
       }

       private bool CanExecuted(object obj)
       {
           throw new NotImplementedException();
       }*/
        #endregion

        public static CommandBindingCollection Command = new CommandBindingCollection();

        public static RoutedCommand WindowCloseCmd = new RoutedCommand("WindowCloseCmd", typeof(ApplicationCommands));
        public static RoutedCommand EnKoCmd = new RoutedCommand("EnKoCmd", typeof(ApplicationCommands));
        public static RoutedCommand ButtonAddCmd = new RoutedCommand("ButtonAddCmd", typeof(ApplicationCommands));


        public ObservableCollection<Menu> Menu_ { get; set; }
        public ObservableCollection<MenuCounting> MenuCounting { get; set; }

        #region field + Property
        // 총 가격
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
        // 한영변환
        private string enko_ = "EN";
        public string EnKo
        {
            get { return this.enko_; }
            set
            {
                this.enko_ = value;
                this.OnPropertyChanged("EnKo");
            }
        }

        #endregion
        public ViewModel()
        {
            this.Menu_ = new ObservableCollection<Menu>();
          

            ViewModel.Command.Add(new CommandBinding(ViewModel.WindowCloseCmd, Executed, CanExecuted));
            ViewModel.Command.Add(new CommandBinding(ViewModel.EnKoCmd, Executed, CanExecuted));
            ViewModel.Command.Add(new CommandBinding(ViewModel.ButtonAddCmd, Executed, CanExecuted));

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

        private void CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;

        }

        private void Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter is MenuCounting)
            {
            }
            else
            {
                if ((e.Command as RoutedCommand).Name == "WindowCloseCmd")
                {
                    btnCount++;

                    if (btnCount == 3)
                    {
                        btnCount = 0;
                        Properties.Settings.Default.Save();
                        CloseAction();
                    }
                }
                else if ((e.Command as RoutedCommand).Name == "EnKoCmd")
                {
                    if (this.EnKo == "EN")
                        this.EnKo = "KO";
                    else
                        this.EnKo = "EN";
                }
                else if ((e.Command as RoutedCommand).Name == "ButtonAddCmd")
                {
                    Menu menu = e.Parameter as Menu;
                    
                    menu.Color_Border = Brushes.Crimson;
                    menu.Color_Icon = Brushes.Crimson;
                }
            }

        }
    }
}
