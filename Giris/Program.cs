
namespace Giris
{
    internal class Program
    {

        static int c = 23;

        static void Main(string[] args)
        {
            #region  asd
            // isimlendirme kurallarına calismanız
            // Camel Case
            // Pascal Case
            // snake Case
            // kebap case
            //Deneme d1 = new Deneme();
            //d1.Batman();
            //Deneme.sMethod();           
            //int a = 23;
            //string b = "metin";
            //Flash();
            //Program.Flash();
            #endregion

            //hm.toplama(22);
            //hm.cikartma(1);
            //Console.WriteLine(HesapMakinesi._conus);


            HesapMakinesi hm = new HesapMakinesi();
            hm._sonuc = 33;
            HesapMakinesi hm2 = new HesapMakinesi();
            Console.WriteLine(hm2._sonuc);
            Console.WriteLine(hm._sonuc);
            HesapMakinesi._conus=7;
            hm._sonuc = hm2._sonuc + 44;
            
            // 0 5
            // 33 
           
            
           
        }

        static void Flash()
        {

        }
       
    }
}