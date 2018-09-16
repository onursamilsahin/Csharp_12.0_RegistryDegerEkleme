using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Csharp_12._2_RegistryKlasorList
{
    class Program
    {
        static void Main(string[] args)
        {


          
         RegistryKey Key= Registry.CurrentUser.OpenSubKey("XYZprojesi",false);//yazma işlemi yapmıyacağım için false yaptım.

            //Burada Subkey içerisinde buluna kayıtların hepsini listeleme işlemi yapılıyor.
         string[] keys= Key.GetValueNames();//Subkey içerisindeki kayıtlar dizi şeklinde geri dönüyor.
            for (int i = 0; i < keys.Length; i++)//Dizi içerisinde ki veriler for ile listeleniyor.Subkey içerisine kayıt ekleme işlemi Csharp 12.1 de gösterliyor.
            {

                Console.WriteLine("Anahtar :{0},value :{1}", keys[i], Key.GetValue(keys[i]));//Keys[i] ile anahtar ismi get value ile ise veri geliyor.

            }





            Console.ReadLine();




        }
    }
}
