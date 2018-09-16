using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace Csharp_12._0_RegistryDegerEkleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //registry işlemleinde çalıştır regedit yazdıktan sonra kayıt defteri düzenleyiicsine 
            //Anahtar ve valur değeri ile istediğimiz kısıma ekleme yapbiliyoruz.
            //burada current user içerisinde anahtar eklenmiştir.
            Registry.CurrentUser.SetValue("Anahtar","Merhaba Registry ");

            //oluşturulan değerin okunması 

          string gelenDeger=Registry.CurrentUser.GetValue("Anahtar").ToString();

            Console.WriteLine("Registry içerisindeki değer:{0}",gelenDeger);
            //eklenen registry i silme 
            //Silinecek kayıtın keyini istiyor.


            Registry.CurrentUser.DeleteValue("Anahtar");





            Console.ReadLine();
        }
    }
}
