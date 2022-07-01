using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Kiosk.View
{
    /// <summary>
    /// TabButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TabButton : UserControl
    {
        public TabButton()
        {
            InitializeComponent();
        }

        private void Tab_Button_Loaded(object sender, RoutedEventArgs e)
        {
            bool designTime = System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject());
            if (designTime)
            {
            }
            else
            {
                foreach (CommandBinding cmd in ViewModels.ViewModel.Command)
                {
                    this.CommandBindings.Add(cmd);
                }
            }
        }
    }
}
