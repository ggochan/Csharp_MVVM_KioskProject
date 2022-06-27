using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVM_Kiosk.Commands;

namespace MVVM_Kiosk.ViewModels
{
    /// <summary>
    /// NuGet - Microsoft.Xaml.Behaviors.Wpf
    /// </summary>
    class WindowViewModel
    {
        public ICommand WindowLoadedCommand { get; private set; }

        public WindowViewModel()
        {
            WindowLoadedCommand = new RelayCommand(WindowLoaded);
        }
        private void WindowLoaded()
        {
            
        }
    }
}
