using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
namespace WMI_Registry_Islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //sürücünün seri numarasına ulaşım 
            string Surucu = "C";//Ulaşmak istediğim sürücünün ismini verdim
            //Aşağıdaki örnekleme ile Diskime eriştim
            ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + Surucu + ":\"");


            Disk.Get();//diski çağırdım.

           RegistryKey keys=  Registry.CurrentUser.OpenSubKey("XYZprojesi",true);//Kayıt defteinde yazmak istediğim subkeyi açtım.


            //Setvalue ile Anahtar ve veri yi ekledim.
            //keys.SetValue("LogicalDisk",Disk["VolumeSerialNumber"].ToString());
            //https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-networkadapterconfiguration kullanılan class ve property ler


            //network card mac adresi öğrneme

            ManagementClass M=new ManagementClass("Win32_NetworkAdapterConfiguration");// Nesne oluşturuldu istediğimiz komut ile 

          ManagementObjectCollection Deger=  M.GetInstances();//Koleksiyon dolduruldu.


            foreach (ManagementObject item in Deger)//managementObject tipi ile döndürüldü
            {

                if ((bool)item["IPEnabled"])//ip adresi aktif olanı almak için kontrol ediyoruz.
                {

                 RegistryKey keyMac =   Registry.CurrentUser.OpenSubKey("XYZprojesi", true);//Daha sonra elde edttiğimiz verileri sistediğimiz subkey atına vermek için subkeyi açıyoruz

                    keyMac.SetValue("Macadress",item["MacAddress"].ToString());//subkey içerisine kayıt ekleme işlemi

                }

               


            }



        }
    }
} 
