using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class Deneme
    {
        // erişim belirteçleri
        // access modifiers
        /*
        public: herkes heryerden erişebilir.
        private: default olarak gelir: sadece kendi class içinde erişebilir.
        protectec: o class özelliğini alan başka bir class erişebilir.
        internal
        internal protectec
        internal private
         */
        public void spidermanMetodu()
        {
            Console.WriteLine(" public metod baska classdan gelen metot");
        }

        internal void Batman()
        {
            Console.WriteLine("internal metod");
        }
        private void Superman()
        {
            Console.WriteLine("private metot");
        }

        protected void Venom()
        {
            Console.WriteLine("protected metot");
        }
        /*
         Classlar cagrıldıkları anda static metotlar 
        ramde yer kaplar
        static metotlara erişmek için:
        Class.Methodadi ile erişilebilir
        Deneme.sMethod(); gibi
        static bir methotdan aynı classtaki 
        başka bir metodu çagırmak istiyorsanız
        diğer metodunda ya static olması gerekir yada 
        aynı classtan bir nesne oluşturmanız lazımdır.          
         */
        public static void sMethod()
        {
            Console.WriteLine("static method calisti");
        }


    }
}
