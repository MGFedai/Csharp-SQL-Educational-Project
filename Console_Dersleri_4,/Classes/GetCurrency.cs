using Console_Dersleri_4_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Console_Dersleri_4_.Classes
{
    public class GetCurrency
    {
        ConsoleDbProjectEntities db = new ConsoleDbProjectEntities();
        public void SaveCurrencyDolar()
        {
            
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string dolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlis = dolarAlis.Replace(".", ",");

            string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            // database e nokta yanlış yere gittiği için virgül ile değiştirdik
            dolarSatis = dolarSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 1;
            t.CurrencyBuying = decimal.Parse(dolarAlis);
            t.CurrencySelling = decimal.Parse(dolarSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

            //string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            //Console.WriteLine("Euro Alis Fiyati: " + euroAlis);
            //string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            //Console.WriteLine("Euro Satis Fiyati: " + euroSatis);
        }
        public void SaveCurrencyEuro()
        {

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlis =euroAlis.Replace(".", ",");

            string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            // database e nokta yanlış yere gittiği için virgül ile değiştirdik
            euroSatis = euroSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 2;
            t.CurrencyBuying = decimal.Parse(euroAlis);
            t.CurrencySelling = decimal.Parse(euroSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

            //string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            //Console.WriteLine("Euro Alis Fiyati: " + euroAlis);
            //string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            //Console.WriteLine("Euro Satis Fiyati: " + euroSatis);
        }
        public void SaveCurrencyPund()
        {

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string pundAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            pundAlis = pundAlis.Replace(".", ",");

            string pundSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            // database e nokta yanlış yere gittiği için virgül ile değiştirdik
            pundSatis = pundSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 4;
            t.CurrencyBuying = decimal.Parse(pundAlis);
            t.CurrencySelling = decimal.Parse(pundSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

            //string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            //Console.WriteLine("Euro Alis Fiyati: " + euroAlis);
            //string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            //Console.WriteLine("Euro Satis Fiyati: " + euroSatis);
        }
    }
}
