using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace T29_Cashier
{
    public interface ITransaction
    {
        // interface members
        public string ShowTransaction(double amount);
        double Money { get; set; }
    }
    public class PaidWithCash : ITransaction
    {
        int billnum = 0;
        public string ShowTransaction(double amount)
        {
            billnum++;
            DateTime today = DateTime.Today;
            string PurchaseDate = today.ToString("dd/MM/yyyy");
            Money += amount;
            string MoneyDecimals = Money.ToString("0.##");
            string msg = $"Paid with cash: bill number {billnum} date: {PurchaseDate} amount {MoneyDecimals}";
            Console.WriteLine(msg);
            return msg;
            
        }
        public void ShowCash()
        {
            string MoneyDecimals = Money.ToString("0.##");
            Console.WriteLine($"Total money in cash: {MoneyDecimals}\n");
        }
        public double Money { get; set; }
    }
    public class PaidWithCard : ITransaction
    {
        int CardNum = 0;
        public string ShowTransaction(double amount)
        {
            CardNum++;
            string CardNumber = $"000{CardNum}-000{CardNum}";
            DateTime today = DateTime.Today;
            string PurchaseDate = today.ToString("dd/MM/yyyy");
            Money += amount;
            string MoneyDecimals = Money.ToString("0.##");
            string msg = $"Transaction to bank: charge from card {CardNumber} date {PurchaseDate} amount {MoneyDecimals}";
            Console.WriteLine(msg);
            return msg;
        }
        public void ShowCash()
        {
            string MoneyDecimals = Money.ToString("0.##");
            Console.WriteLine($"Total money at bank account: {MoneyDecimals}\n");
        }
        public double Money { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PaidWithCash paidWithCash = new PaidWithCash();
            PaidWithCard paidWithCard = new PaidWithCard();

            paidWithCash.ShowTransaction(12.40);
            paidWithCash.ShowTransaction(22.13);
            paidWithCash.ShowCash();
            
            paidWithCard.ShowTransaction(6.59);
            paidWithCard.ShowTransaction(40.53);
            paidWithCard.ShowCash();

            double CashSales = paidWithCash.Money;
            double CardSales = paidWithCard.Money;

            ShowTotalSales(CashSales, CardSales);

            static void ShowTotalSales(double CashSales, double CardSales)
            {
                double TotalSalesValue = CashSales + CardSales;
                string TotalSales = TotalSalesValue.ToString("0.##");
                DateTime today = DateTime.Today;
                string SalesDate = today.ToString("dddd MMMM yyyy");
                Console.WriteLine($"Total Sales today {SalesDate}, is {TotalSales}");

            }
        }
        
    }
}