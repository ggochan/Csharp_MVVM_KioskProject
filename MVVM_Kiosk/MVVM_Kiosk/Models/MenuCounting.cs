using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Kiosk.Models
{
    /// <summary>
    /// Count - 메뉴 수량
    /// Count_Price - 메뉴 수량 합계
    /// </summary>
    class MenuCounting : MenuBase
    {
        private int count_;
        public int Count
        {
            get { return this.count_; }
            set
            {
                this.count_ = value;
                this.OnPropertyChanged("Count");
            }
        }
        private int count_price;
        public int Count_Price
        {
            get { return this.count_price; }
            set
            {
                this.count_price = value;
                this.OnPropertyChanged("Count_Price");
            }
        }
        public MenuCounting()
        {

        }
    }
}
