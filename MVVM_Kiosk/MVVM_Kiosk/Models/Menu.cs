using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MVVM_Kiosk.Models
{
    /// <summary>
    /// In_Count - 하나의 메뉴를 묶어 팔 때
    ///     예시) 슈크림 4개 => 3000원
    /// Color_Border - 메뉴 테두리 색상
    /// Color_Icon - 메뉴 좌상단 아이콘 색상
    /// </summary>
    class Menu : MenuBase
    {
        public int In_Count { get; set; } = 1;

        // Menu select Border Color
        private Brush color_border = Brushes.WhiteSmoke;
        public Brush Color_Border
        {
            get { return this.color_border; }
            set
            {
                this.color_border = value;
                //this.Str_Color = value.ToString();
                this.OnPropertyChanged("Color_Border");
            }
        }
        // Menu select Icon Color
        private Brush color_icon = Brushes.White;
        public Brush Color_Icon
        {
            get { return this.color_icon; }
            set
            {
                this.color_icon = value;
                //this.Str_Color = value.ToString();
                this.OnPropertyChanged("Color_Icon");
            }
        }

    

        /* private readonly BrushConverter ColorConverter = new BrushConverter();

         private string str_color;
         public string Str_Color
         {
             get
             {
                 return this.str_color;
             }
             set
             {
                 this.str_color = value;
                 this.color_ = (Brush)this.ColorConverter.ConvertFrom(value);
             }
         }*/
        
        public Menu()
        {

        }
    }
}
