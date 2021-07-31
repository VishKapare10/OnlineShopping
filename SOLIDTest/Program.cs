using System;

namespace SOLIDTest
{
    public class Data{}
    public interface IService{
        void Get(Data message);
        void Process(Data message);
        void Dispatch(Data message);
    }

    public class PaymentServiceProvider: IService{
        public void Get(Data message){
            Console.WriteLine("Order received");
        }
        public void Process(Data message){
            Console.WriteLine("Order processed");
        }

        public void Dispatch(Data message){
            Console.WriteLine("Order dispatched");
        }
    }

    public class DeliveryServiceProvider: IService{
        public void Get(Data message){
             Console.WriteLine("Order received");
        }
        public void Process(Data message){
            Console.WriteLine("Order processed");
        }

        public void Dispatch(Data message){
            Console.WriteLine("Order dispatched");
        }
    }

    public class BillingServiceProvider: IService{
        public void Get(Data message){
            Console.WriteLine("Order received");
        }
        public void Process(Data message){
            Console.WriteLine("Order processed");
        }

        public void Dispatch(Data message){
            Console.WriteLine("Order dispatched");
        }
    }

    //Acts like a manager
    public class Server{
        IService service;

        public Server(IService svc){
            this.service=svc;
        }
        public void Get(Data message){
            service.Get(message);
        }
        public void Process(Data message){
            service.Process(message);
        }

        public void Dispatch(Data message){
            service.Dispatch(message);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing single point of resposibility principle (SRP)");
            IService service=new PaymentServiceProvider();
            Server server=new Server(service);
            Data msg=new Data();
            server.Get(msg);
            server.Process(msg);
            server.Dispatch(msg);
            
        }
    }
}
