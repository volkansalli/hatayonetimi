using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.WriteLine("bir tam sayi giriniz");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            }
            catch(Exception ex){
                Console.WriteLine("hatali giris "+ ex.Message.ToString());
            }
            finally{
                Console.WriteLine("dogru giris yapildi");
            }
           
            try {
                Console.WriteLine("lütfen console da NULL dan farklı bir giris yapınız");
                int y=int.Parse(Console.ReadLine());

            }
            catch (ArgumentException ex){
                Console.WriteLine("hatali giris lütfen girdi yapmadan enter e basmayın");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine(ex);
            }
            
        }
    }
}
