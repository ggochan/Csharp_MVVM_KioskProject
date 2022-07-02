using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MVVM_Kiosk.Models
{
    class TabMenu : NotifyPropertyChanged
    {
        // 탭 활성화 IsChecked
        private bool tab_check = false;
        public bool Tab_Check
        {
            get { return this.tab_check; }
            set
            {
                this.tab_check = value;
                this.OnPropertyChanged("Tab_Check");
            }
        }
        // 탭 위치 번호
        public int Tab_position { get; set; }

        // 탭 이름
        private string tab_name;
        public string Tab_Name
        {
            get { return this.tab_name; }
            set
            {
                this.tab_name = value;
                this.OnPropertyChanged("Tab_Name");
            }

        }

        // TabMenu BackGround + Border Color
        private Brush tab_color = new SolidColorBrush(Color.FromRgb(54,54,54)); // Black
        // new SolidColorBrush(Color.FromRgb(240, 238, 237)); // Light Gray
        public Brush Tab_Color
        {
            get { return this.tab_color; }
            set
            {
                this.tab_color = value;
                this.OnPropertyChanged("Tab_Color");
            }
        }
        private Brush tab_text_color = new SolidColorBrush(Color.FromRgb(240, 238, 237)); 
        public Brush Tab_Text_Color
        {
            get { return this.tab_text_color; }
            set
            {
                this.tab_text_color = value;
                this.OnPropertyChanged("Tab_Text_Color");
            }
        }
    }
    class CommonModel { }
}
