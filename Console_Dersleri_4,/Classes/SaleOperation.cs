using Console_Dersleri_4_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_4_.Classes
{
    public class SaleOperation
    {
        ConsoleDbProjectEntities db = new ConsoleDbProjectEntities();
        public void CustomerSaleOperationAlis()
        {
            var values = db.TblOperation.Where(x=>x.OperationType=="alis").ToList();
            foreach(var item in values)
            {
                Console.WriteLine("ID: "+item.ID+"Müşteri:"+item.CostumerName+""+item.CostumerSurname+"Döviz:"+item.TblCurrency.CurrencyName+"İşlem Türü"+item.OperationType
                    + "Kur Değeri "+item.CurrentValue+"Alınan Tutar"+ item.Amount+" Toplam Tutar: "+item.TotalPrice);    
            }
        }
        public void CustomerSaleOperationSatis()
        {
            var values = db.TblOperation.Where(x => x.OperationType == "Satıs").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: " + item.ID + "Müşteri:" + item.CostumerName + "" + item.CostumerSurname + "Döviz:" + item.TblCurrency.CurrencyName + "İşlem Türü" + item.OperationType
                    + "Kur Değeri " + item.CurrentValue + "Alınan Tutar" + item.Amount + " Toplam Tutar: " + item.TotalPrice);
            }
        }
    }

}
