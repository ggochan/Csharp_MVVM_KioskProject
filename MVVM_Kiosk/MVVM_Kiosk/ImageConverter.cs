using MVVM_Kiosk.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MVVM_Kiosk
{
    public class ImagePath
    {
        public BitmapSource Image_bitmap { get; set; }
        public string Image_menu { get; set; }
        public int Image_price { get; set; }
    }

    public static class ImageConverter
    {
        public static List<ImagePath> DirectroyToPathImage()
        {
            List<ImagePath> imglist = new List<ImagePath>();

     

            string[] path = Directory.GetFiles(@"F:\project\Csharp_MVVM_KioskProject\Csharp_MVVM_KioskProject\MVVM_Kiosk\MVVM_Kiosk\Resources", "*.png", SearchOption.AllDirectories);

            char[] spchar = { ',', '.' };

            for (int i = 0; i < path.Length; i++)
            {
                if (!path[i].Contains("커피상표"))
                {
                    Bitmap bitmap = (Bitmap)Bitmap.FromFile(@path[i]);
                    string path_name = Path.GetFileName(path[i]);
                    string[] imagesplit = path_name.Split(spchar);

                    imglist.Add(new ImagePath
                    {
                        Image_bitmap = BitmapTobitmapSource(bitmap),
                        Image_menu = imagesplit[0],
                        Image_price = int.Parse(imagesplit[1])
                    });
                }
            }
            return imglist;
           
        }
        public static BitmapSource BitmapTobitmapSource(Bitmap source)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                         source.GetHbitmap(),
                         IntPtr.Zero,
                         Int32Rect.Empty,
                         BitmapSizeOptions.FromEmptyOptions());
        }
        public static void ImageToBitmap()
        { 

        }
        public static void BitmapToImage()
        {

        }
    }
}
