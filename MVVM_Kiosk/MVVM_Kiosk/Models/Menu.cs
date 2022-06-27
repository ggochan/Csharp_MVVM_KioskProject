using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Kiosk.Models
{
    /// <summary>
    /// In_Count - 하나의 메뉴를 묶어 팔 때
    ///     예시) 슈크림 4개 => 3000원
    /// </summary>
    class Menu : MenuBase
    {
        public int In_Count { get; set; } = 1;
        

        //img byte ?
        public Menu()
        {

        }
    }
}
