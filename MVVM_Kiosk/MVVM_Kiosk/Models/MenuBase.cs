using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Kiosk.Models
{
    /// <summary>
    /// Name - 메뉴 이름
    /// Price - 메뉴 가격
    /// </summary>
    class MenuBase : NotifyPropertyChanged
    {
        public string Name { get; set; }

        private int price_;

        public int Price
        {
            get { return this.price_; }
            set
            {
                this.price_ = value;
                this.OnPropertyChanged("Price");
            }
        }
    }
}
