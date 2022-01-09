using System;
using AulaEnum.Entities;
using AulaEnum.Entities.Enums; // para utilizar classes de outros namespaces
namespace AulaEnum
{
    class Program
    {
        public static void Main(String[] args)
        {
            Order order = new Order
            { 
                //Iniciando valores no objeto
                Id = 1050,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
                
            };

            Console.WriteLine(order);

            //conversão de enumeração p/ string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //conversão de string p/ enumeração

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}