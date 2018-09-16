using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace Csharp_12._1_RegistryKlasorEkle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subkey oluşturma yani registry içerisinde currentuser içerisine kalsör ekleme
            Registry.CurrentUser.CreateSubKey("XYZprojesi");

            //Subkey in içerisine gidip yeni bir değer ekleme işlemi

           RegistryKey Key= Registry.CurrentUser.OpenSubKey("XYZprojesi",true);//subkeyi yerini bulma yeni veri eklemek için
            //Açılacak subkey için ismini veriyorz ancak bu sadece okuma işlemine izin veriyor bunun için ',' den sonra true ile yazılabilir olduğunu söylüyoruz .
         
           //Burada key ve data ile beraber ekleme işlemi gerçekleştiriliyor.
                Key.SetValue("SeriNumarasi", "1996");
            Key.SetValue("SeriNumarasi2", "1234");
            Key.SetValue("SeriNumarasi3", "12345");
            //Key vererek kayıt ı sorgulama 
            string seriNo = Key.GetValue("SeriNumarasi").ToString();

                Console.WriteLine("Kayıt:{0}",seriNo);



        }
    }
}
