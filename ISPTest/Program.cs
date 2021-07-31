using System;

//Interface Segregation Principle (ISP)
namespace ISPTest
{
    public interface IOrder
    {
        void AddToCart();
    }
 
    public interface IOnlineOrder
    {
        void ProcessThroghPaymentGateway();
    }
 
    //Mutiple interface inheritance
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    
        public void ProcessThroghPaymentGateway()
        {
            //process through credit card, debit cart, UPI
            //NetBanking
        }
    }
 
    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
        
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISP -Interface segregation principle");
            OnlineOrder onlineOrder=new OnlineOrder();
            onlineOrder.AddToCart();
            onlineOrder.ProcessThroghPaymentGateway();
        }
    }
}