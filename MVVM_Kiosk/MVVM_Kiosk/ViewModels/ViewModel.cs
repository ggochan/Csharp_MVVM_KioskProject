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

        // Window Event cmd
        public static RoutedCommand WindowCloseCmd = new RoutedCommand("WindowCloseCmd", typeof(ApplicationCommands));
        public static RoutedCommand TabWheelCmd = new RoutedCommand("TabWheelCmd", typeof(ApplicationCommands));

        //UI Event cmd
        public static RoutedCommand EnKoCmd = new RoutedCommand("EnKoCmd", typeof(ApplicationCommands));
        public static RoutedCommand ButtonAddCmd = new RoutedCommand("ButtonAddCmd", typeof(ApplicationCommands));
        public static RoutedCommand TabAddCmd = new RoutedCommand("TabAddCmd", typeof(ApplicationCommands));

        public ObservableCollection<Menu> Menu_ { get; set; }
        public ObservableCollection<MenuCounting> MenuCounting { get; set; }
        public ObservableCollection<TabMenu> TabMenu_ { get; set; }

        private List<ImagePath> imagepath;
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
            this.TabMenu_ = new ObservableCollection<TabMenu>();

            Window_Configuration();

            ViewModel.Command.Add(new CommandBinding(ViewModel.WindowCloseCmd, Executed, CanExecuted));
            ViewModel.Command.Add(new CommandBinding(ViewModel.EnKoCmd, Executed, CanExecuted));
            ViewModel.Command.Add(new CommandBinding(ViewModel.ButtonAddCmd, Executed, CanExecuted));
            ViewModel.Command.Add(new CommandBinding(ViewModel.TabAddCmd, Executed, CanExecuted));
            ViewModel.Command.Add(new CommandBinding(ViewModel.TabWheelCmd, Executed, CanExecuted));

        }
        private void Window_Configuration()
        {
            this.TabMenu_.Add(new TabMenu { Tab_Name = "시즌메뉴", Tab_position = TabMenu_.Count, Tab_Check = true
            });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "커피(ICE)", Tab_position = TabMenu_.Count,
                Tab_Color = new SolidColorBrush(Color.FromRgb(240, 238, 237)),
                Tab_Text_Color = new SolidColorBrush(Color.FromRgb(54, 54, 54))
            });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "커피(HOT)", Tab_position = TabMenu_.Count });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "스무디&프라페", Tab_position = TabMenu_.Count });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "티", Tab_position = TabMenu_.Count });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "------예시-------", Tab_position = TabMenu_.Count });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "------예시-------", Tab_position = TabMenu_.Count });
            this.TabMenu_.Add(new TabMenu { Tab_Name = "------예시-------", Tab_position = TabMenu_.Count });



            this.imagepath = new List<ImagePath>(ImageConverter.DirectroyToPathImage());

            foreach (ImagePath path in imagepath)
            {
                this.Menu_.Add(new Menu { Name = path.Image_menu, Price = path.Image_price, Bitmapsoruce = path.Image_bitmap });
            }

        }
        private void First_Window()
        {

        }
        private void CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;

        }

        private void Executed(object sender, MouseWheelEventArgs e)
        {
            
        }
            private void Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter is MenuCounting) // 선택된 메뉴
            {
                
            }
            else // 그 외
            {
                if ((e.Command as RoutedCommand).Name == "WindowCloseCmd") // 창 닫기
                {
                    btnCount++;

                    if (btnCount == 3)
                    {
                        btnCount = 0;
                        Properties.Settings.Default.Save();
                        CloseAction();
                    }
                }
                else if ((e.Command as RoutedCommand).Name == "EnKoCmd") // 한영
                {
                    if (this.EnKo == "EN")
                        this.EnKo = "KO";
                    else
                        this.EnKo = "EN";
                }
                else if ((e.Command as RoutedCommand).Name == "TabAddCmd") // 탭
                {
                    TabMenu tabMenu = e.Parameter as TabMenu;

                    for (int t_cnt = 0; t_cnt < this.TabMenu_.Count-1; t_cnt++)
                    {
                        if (this.TabMenu_[t_cnt].Tab_position == tabMenu.Tab_position) // 클릭된 탭 체크
                        {
                            this.TabMenu_[t_cnt].Tab_Check = true;
                        }
                        else
                        {
                            this.TabMenu_[t_cnt].Tab_Check = false;
                        }

                        if (this.TabMenu_[t_cnt].Tab_Check == false) // don't click 
                        {
                            this.TabMenu_[t_cnt].Tab_Color = new SolidColorBrush(Color.FromRgb(54, 54, 54));
                            this.TabMenu_[t_cnt].Tab_Text_Color = Brushes.White;
                        }
                        else // click
                        {
                            this.TabMenu_[t_cnt].Tab_Color = new SolidColorBrush(Color.FromRgb(240, 238, 237));
                            this.TabMenu_[t_cnt].Tab_Text_Color = new SolidColorBrush(Color.FromRgb(54, 54, 54));
                        }
                    }
                }
                else if ((e.Command as RoutedCommand).Name == "ButtonAddCmd")
                {
                    Menu menu = e.Parameter as Menu;

                    menu.Btn_Check = ((menu.Btn_Check == true) ? false : true); // Button IsChecked

                    if (menu.Btn_Check == false) // don't click 
                    {
                        menu.Color_Border = Brushes.WhiteSmoke;
                        menu.Color_Icon = Brushes.White;
                    }

                    else if (menu.Btn_Check == true) // click
                    {
                        menu.Color_Border = Brushes.Crimson;
                        menu.Color_Icon = Brushes.Crimson;
                    }

                }
            }
        }
    }
}
