using System;

namespace Pr7_SRP
{
    public class OrderService
    {
        public void CreateOrder()
        {
            Console.WriteLine("Place Your Order");
        }
        public void Removeorder()
        {
            Console.WriteLine("Cancle Your Order");
        }
    }

    public class PaymentService
    {
        public void MakePayment()
        {
            Console.WriteLine("Make your payment");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            service.CreateOrder();
            service.Removeorder();
            PaymentService service2 = new PaymentService();
            service2.MakePayment();

        }
    }
}