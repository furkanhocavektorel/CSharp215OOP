using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class HesapMakinesi
    {
        // field
        public int _sonuc = 0;
        public static int _conus=22;
        // prop
        public int MyProperty { get; set; }
        public void toplama(int sayi1)
        {
           
            _sonuc = sayi1 + _sonuc;
        }
        public void cikartma(int sayi1)
        {
            _sonuc = _sonuc - sayi1;
            
        }
        public void ekranaBas()
        {
            Console.WriteLine(_sonuc);
        }
    }
}
