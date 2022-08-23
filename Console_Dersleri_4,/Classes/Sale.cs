using Console_Dersleri_4_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_4_.Classes
{
    public class Sale
    {
        ConsoleDbProjectEntities db = new ConsoleDbProjectEntities();
        public void makeSale(string customerName,string customerSurname,int currencyCode,string operationtType,decimal currentValue,decimal amount,decimal totalPrice
            )
        {
            TblOperation t = new TblOperation();
            t.CostumerName = customerName;
            t.CostumerSurname = customerSurname;
            t.CurrencyID=currencyCode;
            t.OperationType=operationtType;
            t.CurrentValue=currentValue;
            t.Amount = amount;
            t.TotalPrice=totalPrice;    
            t.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOperation.Add(t);
            db.SaveChanges();
            Console.WriteLine("Satış işlemi başarılı bir şekilde gerçekleşti");


            



        }
    }
}
