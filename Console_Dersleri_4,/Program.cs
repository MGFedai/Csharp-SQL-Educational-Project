using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Console_Dersleri_4_.Classes;
using Console_Dersleri_4_.Model;

namespace Console_Dersleri_4_
{
    internal class Program
    {
        //TÜRKİYE MERKEZ BANKASINDAN  ASAGIDAKİ KURLARI CONSOLUMUZA ÇEKTİK.
        
        static void Main(string[] args)
        {
            GetCurrency getCurrency = new GetCurrency();
            ConsoleDbProjectEntities db = new ConsoleDbProjectEntities();
            Sale sale = new Sale();
            void CurrencyList()
            {
                Console.WriteLine();
                Console.WriteLine("Döviz Listesi");
                Console.WriteLine();
                var values = db.TblCurrency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ID + " " + item.CurrencyName + " " + item.CurrencySymbol);
                }
            }
            void CurrentCurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Güncel Kur  Listesi");
                Console.WriteLine();
                var values = db.TblCurrencyValue.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine("Döviz:  " + item.TblCurrency.CurrencyName + " " + item.TblCurrency.CurrencySymbol +
                        "Alış:  " + item.CurrencyBuying + "Satış:  " + item.CurrencySelling);
                }
            }
            void GetCurrencyClass()
            {
                //GetCurrency getCurrency = new GetCurrency();
                getCurrency.SaveCurrencyDolar();
                getCurrency.SaveCurrencyEuro();
                getCurrency.SaveCurrencyPund();
            }
            Console.WriteLine("Döviz İşlemlerine Hosgeldiniz");
            Console.WriteLine(" ");
            Console.WriteLine("Mevcut Kullanıcı: Admin"+"   Tarih:"+DateTime.Now.ToShortDateString());
            Console.WriteLine(" ");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine(" ");
            Console.WriteLine("1-Döviz Listesi");
            Console.WriteLine("2-Güncel Kurlar");
            Console.WriteLine("3-Satış Yap");
            Console.WriteLine("4-Müşterilere Yapılan Satışlar Hareketleri ");
            Console.WriteLine("5-Müşterden Alınan Satış Hareketleri");
            Console.WriteLine("6-Kurları Veri Tabanına Kaydet");
            Console.WriteLine("7-Çıkış Yap");
            Console.WriteLine(" ");
            Console.Write("İşlem Numarası: ");
            string choose;
            choose = Console.ReadLine();
            if (choose == "1" || choose=="01"){
                CurrencyList(); 
            }
            if (choose == "2" || choose == "02")
            {
                CurrentCurrency();
            }
            if (choose == "3" || choose == "03")
            {
                Console.WriteLine("");
                Console.Write("Müşteri Adı: ");
                string customerName =  Console.ReadLine();
                Console.Write("Müşteri Soyadı: ");
                string customerSurname = Console.ReadLine();
                Console.Write("Döviz Kodu: ");
                int currenctCode = int.Parse(Console.ReadLine());
                Console.Write("İslem Türü: ");
                string oprationType = Console.ReadLine();
                Console.Write("Güncel Kur Degeri: ");
                decimal currentValue =decimal.Parse(Console.ReadLine());
                Console.Write("Alınacak Tutar: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.Write("Toptam Ücret: ");
                decimal totalAmount =decimal.Parse(Console.ReadLine());
                sale.makeSale(customerName, customerSurname, currenctCode, oprationType, currentValue, amount, totalAmount);
                //CurrentCurrency();
            }
            if (choose == "6" || choose == "06")
            {
                GetCurrencyClass();
                Console.WriteLine("Dövizler Başarılı bir şekilde Kayır edildi");
            }
            if (choose == "4" || choose == "04")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationAlis();
            }
            if (choose == "5" || choose == "05")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationSatis();
            }
            if (choose == "7" || choose == "07")
            {
                Console.WriteLine("Tüm sorularınız için m.g.fedai@gmail.com adresinden bana ulaşamabilirsiniz.");
            }
            if (choose == "8" || choose == "08")
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
